using System; 
using Server; 
using Server.Mobiles;
using Server.Engines.Craft;

namespace Server.Items
{
	public class HammerOfHephaestus : AncientSmithyHammer
	{
		public override int LabelNumber{ get{ return 1077740; } } // Hammer of Hephaestus

		[Constructable]
		public HammerOfHephaestus() : base( 10, 20 )
		{
			LootType = LootType.Blessed;
			Hue = 0x0;

			Timer.DelayCall( TimeSpan.FromMinutes( 5 ), TimeSpan.FromMinutes( 5 ), new TimerCallback( Tick_Callback ) );

			ItemValue = ItemValue.Uncommon;
		}

		private void Tick_Callback()
		{		
			if ( UsesRemaining < 20 )
				UsesRemaining += 1;
				
			InvalidateProperties();
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( IsChildOf( from.Backpack ) || Parent == from )
			{
				if ( UsesRemaining > 0 )
				{
					CraftSystem system = this.CraftSystem;
	
					int num = system.CanCraft( from, this, null );
	
					if ( num > 0 )
					{
						from.SendLocalizedMessage( num );
					}
					else
					{
						CraftContext context = system.GetContext( from );
	
						from.SendGump( new CraftGump( from, system, this, null ) );
					}
				}
				else
					from.SendLocalizedMessage( 1072306 ); // You must wait a moment for it to recharge.
			}
			else
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
		}

		public override bool CanEquip( Mobile from )
		{
			if ( UsesRemaining > 0 )
				return base.CanEquip( from );

			from.SendLocalizedMessage( 1072306 ); // You must wait a moment for it to recharge.
			return false;
		}

		public HammerOfHephaestus( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();

			if ( Hue == 0x482 )
				Hue = 0x0;
				
			Timer.DelayCall( TimeSpan.FromMinutes( 5 ), TimeSpan.FromMinutes( 5 ), new TimerCallback( Tick_Callback ) );
		}
	}
}