using System;
using Server.Items;

namespace Server.Items
{
	public class CosmicOil : Item, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public CosmicOil() : this( 1 )
		{
		}

		[Constructable]
		public CosmicOil( int amount ) : base( 0x2DB6 )
		{
			Name = "cosmic oil";
			Hue = 1462;
			Stackable = true;
			Amount = amount;
			Weight = 1.0;
			ItemValue = ItemValue.Epic;
		}

		public CosmicOil( Serial serial ) : base( serial )
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