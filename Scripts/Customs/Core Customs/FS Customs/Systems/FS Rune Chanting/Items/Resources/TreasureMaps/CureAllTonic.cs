using System;
using Server.Items;

namespace Server.Items
{
	public class CureAllTonic : Item, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public CureAllTonic() : this( 1 )
		{
		}

		[Constructable]
		public CureAllTonic( int amount ) : base( 0x099B )
		{
			Name = "Gandolf's Cure-all Tonic";
			Stackable = true;
			Amount = amount;
			Weight = 1.0;
			ItemValue = ItemValue.Resource;
		}

		public CureAllTonic( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}