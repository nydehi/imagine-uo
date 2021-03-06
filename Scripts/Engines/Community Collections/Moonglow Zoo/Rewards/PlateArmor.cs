using System;
using Server;

namespace Server.Items
{
	public class RoyalZooPlateLegs : PlateLegs
	{
		public override int LabelNumber{ get{ return 1073224; } } // Platemail Armor of the Britannia Royal Zoo
	
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RoyalZooPlateLegs() : base()
		{
			Hue = 0x109;
		
			Attributes.Luck = 100;
			Attributes.DefendChance = 10;
			ArmorAttributes.MageArmor = 1;
		}

		public RoyalZooPlateLegs( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
	
	public class RoyalZooPlateGloves : PlateGloves
	{
		public override int LabelNumber{ get{ return 1073224; } } // Platemail Armor of the Britannia Royal Zoo
	
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RoyalZooPlateGloves() : base()
		{
			Hue = 0x109;
		
			Attributes.Luck = 100;
			Attributes.DefendChance = 10;
			ArmorAttributes.MageArmor = 1;
		}

		public RoyalZooPlateGloves( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
	
	public class RoyalZooPlateGorget : PlateGorget
	{
		public override int LabelNumber{ get{ return 1073224; } } // Platemail Armor of the Britannia Royal Zoo
	
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RoyalZooPlateGorget() : base()
		{
			Hue = 0x109;
		
			Attributes.Luck = 100;
			Attributes.DefendChance = 10;
			ArmorAttributes.MageArmor = 1;
		}

		public RoyalZooPlateGorget( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
	
	public class RoyalZooPlateArms : PlateArms
	{
		public override int LabelNumber{ get{ return 1073224; } } // Platemail Armor of the Britannia Royal Zoo
	
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RoyalZooPlateArms() : base()
		{
			Hue = 0x109;
		
			Attributes.Luck = 100;
			Attributes.DefendChance = 10;
			ArmorAttributes.MageArmor = 1;
		}

		public RoyalZooPlateArms( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
	
	public class RoyalZooPlateChest : PlateChest
	{
		public override int LabelNumber{ get{ return 1073224; } } // Platemail Armor of the Britannia Royal Zoo
	
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RoyalZooPlateChest() : base()
		{
			Hue = 0x109;
		
			Attributes.Luck = 100;
			Attributes.DefendChance = 10;
			ArmorAttributes.MageArmor = 1;
		}

		public RoyalZooPlateChest( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
	
	public class RoyalZooPlateFemaleChest : FemalePlateChest
	{
		public override int LabelNumber{ get{ return 1073224; } } // Platemail Armor of the Britannia Royal Zoo
	
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RoyalZooPlateFemaleChest() : base()
		{
			Hue = 0x109;
		
			Attributes.Luck = 100;
			Attributes.DefendChance = 10;
			ArmorAttributes.MageArmor = 1;
		}

		public RoyalZooPlateFemaleChest( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
	
	public class RoyalZooPlateHelm : PlateHelm
	{
		public override int LabelNumber{ get{ return 1073224; } } // Platemail Armor of the Britannia Royal Zoo
	
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RoyalZooPlateHelm() : base()
		{
			Hue = 0x109;
		
			Attributes.Luck = 100;
			Attributes.DefendChance = 10;
			ArmorAttributes.MageArmor = 1;
		}

		public RoyalZooPlateHelm( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
}