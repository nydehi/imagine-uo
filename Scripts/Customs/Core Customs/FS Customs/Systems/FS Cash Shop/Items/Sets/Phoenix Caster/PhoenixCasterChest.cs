using System;
using Server.Items;

namespace Server.Items
{
	public class PhoenixCasterChest : LeatherChest
	{
		public override SetItem SetID{ get{ return SetItem.PhoenixCaster; } }
		public override int Pieces{ get{ return 14; } }
		
		public override int BasePhysicalResistance{ get{ return 3; } }
		public override int BaseFireResistance{ get{ return 6; } }
		public override int BaseColdResistance{ get{ return 8; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 8; } }

		[Constructable]
		public PhoenixCasterChest() : base()
		{
			Name = "a blazing phoenix leather tunic";

			SetHue = 43;
			
			Attributes.BonusMana = 5;
			Attributes.ReflectPhysical = 3;
			AbsorptionAttributes.EaterCold = 20;
			
			SetAttributes.LowerRegCost = 100;
			SetAttributes.LowerManaCost = 50;
			SetAttributes.Luck = 2500;
			SetAttributes.BonusInt = 10;
			SetSkillBonuses.SetValues( 0, SkillName.Meditation, 120 );

			SetSelfRepair = 5;
			SetPhysicalBonus = 10;
			SetFireBonus = 10;
			SetColdBonus = 10;
			SetPoisonBonus = 10;
			SetEnergyBonus = 10;
		}

		public PhoenixCasterChest( Serial serial ) : base( serial )
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