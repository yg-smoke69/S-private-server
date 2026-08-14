using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002EAB")]
public class UIModelAvatarBase : UIBaseModel
{
	[Token(Token = "0x2002EAC")]
	public enum EWardrobeType
	{
		[Token(Token = "0x4011D2C")]
		CLOTHESTYPENONE = 0,
		[Token(Token = "0x4011D2D")]
		Head = 1,
		[Token(Token = "0x4011D2E")]
		Hands = 2,
		[Token(Token = "0x4011D2F")]
		Chest = 3,
		[Token(Token = "0x4011D30")]
		Legs = 4,
		[Token(Token = "0x4011D31")]
		Feet = 5,
		[Token(Token = "0x4011D32")]
		Waist = 6,
		[Token(Token = "0x4011D33")]
		Eye = 7,
		[Token(Token = "0x4011D34")]
		Face = 8,
		[Token(Token = "0x4011D35")]
		Parachute = 9,
		[Token(Token = "0x4011D36")]
		ParachuteBag = 10,
		[Token(Token = "0x4011D37")]
		Hair = 11,
		[Token(Token = "0x4011D38")]
		Set = 12,
		[Token(Token = "0x4011D39")]
		BagPack = 13,
		[Token(Token = "0x4011D3A")]
		HeadAdditive = 14,
		[Token(Token = "0x4011D3B")]
		EventTrigger = 20,
		[Token(Token = "0x4011D3C")]
		All = 21
	}

	[Token(Token = "0x2002EAD")]
	public enum EGenderType
	{
		[Token(Token = "0x4011D3E")]
		GENDERTYPENONE,
		[Token(Token = "0x4011D3F")]
		Woman,
		[Token(Token = "0x4011D40")]
		Man
	}

	[Token(Token = "0x2002EAE")]
	public enum EHairType
	{
		[Token(Token = "0x4011D42")]
		HAIRTYPENONE,
		[Token(Token = "0x4011D43")]
		SINGLEHAIR,
		[Token(Token = "0x4011D44")]
		DOUBLEHAIR
	}

	[Token(Token = "0x2002EAF")]
	public enum EClothGenderType
	{
		[Token(Token = "0x4011D46")]
		GENDERTYPENONE,
		[Token(Token = "0x4011D47")]
		Woman,
		[Token(Token = "0x4011D48")]
		Man,
		[Token(Token = "0x4011D49")]
		Common
	}

	[Token(Token = "0x2002EB0")]
	public enum EAvatarType
	{
		[Token(Token = "0x4011D4B")]
		AVATARTYPENONE,
		[Token(Token = "0x4011D4C")]
		DefaultCharacter,
		[Token(Token = "0x4011D4D")]
		CharacterWithSkill,
		[Token(Token = "0x4011D4E")]
		OnlyCharacter,
		[Token(Token = "0x4011D4F")]
		OnlySkill
	}

	[Serializable]
	[Token(Token = "0x2002EB1")]
	public class AvatarSkin
	{
		[Token(Token = "0x4011D50")]
		[FieldOffset(Offset = "0x8")]
		public Color color;

		[Token(Token = "0x4011D51")]
		[FieldOffset(Offset = "0x18")]
		public float colorNormalized;

		[Token(Token = "0x4011D52")]
		[FieldOffset(Offset = "0x1C")]
		public uint avatar_id;

		[Token(Token = "0x4011D53")]
		[FieldOffset(Offset = "0x20")]
		public uint skin_color;

		[Token(Token = "0x6013843")]
		[Address(RVA = "0x30BF6B8", Offset = "0x30BF6B8", VA = "0x30BF6B8")]
		public AvatarSkin()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2002EB2")]
	public class AvatarCloth
	{
		[Token(Token = "0x4011D54")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<int, uint> ClothDict;

		[Token(Token = "0x6013844")]
		[Address(RVA = "0x30BF6B0", Offset = "0x30BF6B0", VA = "0x30BF6B0")]
		public AvatarCloth()
		{
		}
	}

	[Token(Token = "0x2002EB3")]
	public class AvatarData
	{
		[Token(Token = "0x4011D55")]
		[FieldOffset(Offset = "0x8")]
		public bool dirty;

		[Token(Token = "0x4011D56")]
		[FieldOffset(Offset = "0xC")]
		public uint avatarID;

		[Token(Token = "0x4011D57")]
		[FieldOffset(Offset = "0x10")]
		public bool isFemale;

		[Token(Token = "0x4011D58")]
		[FieldOffset(Offset = "0x14")]
		public uint skin_color;

		[Token(Token = "0x4011D59")]
		[FieldOffset(Offset = "0x18")]
		public EHairType hairType;

		[Token(Token = "0x4011D5A")]
		[FieldOffset(Offset = "0x1C")]
		public Dictionary<int, uint> ClothDict;

		[Token(Token = "0x6013845")]
		[Address(RVA = "0x30B1530", Offset = "0x30B1530", VA = "0x30B1530")]
		public AvatarData()
		{
		}

		[Token(Token = "0x6013846")]
		[Address(RVA = "0x30B33B0", Offset = "0x30B33B0", VA = "0x30B33B0")]
		public static AvatarData Clone(AvatarData sr)
		{
			return null;
		}
	}

	[Token(Token = "0x4011D13")]
	public const uint PropID_AvatarClothRetOK = 2u;

	[Token(Token = "0x4011D14")]
	public const uint PropID_AvatarSkinRetOK = 4u;

	[Token(Token = "0x4011D15")]
	public const uint PropID_AvatarBagpack = 8u;

	[Token(Token = "0x4011D16")]
	[FieldOffset(Offset = "0x0")]
	private static Color _FemaleStartColor;

	[Token(Token = "0x4011D17")]
	[FieldOffset(Offset = "0x10")]
	private static Color _AvatarStartColor;

	[Token(Token = "0x4011D18")]
	[FieldOffset(Offset = "0x20")]
	private static Color _AvatarEndColor;

	[Token(Token = "0x4011D19")]
	public const string DefaultInGameRaceFemale = "BaseFemale";

	[Token(Token = "0x4011D1A")]
	public const string DefaultInGameRaceMale = "BaseMale";

	[Token(Token = "0x4011D1B")]
	public const string HQInGameRaceFemale = "BaseFemale_N";

	[Token(Token = "0x4011D1C")]
	public const string HQInGameRaceMale = "BaseMale_N";

	[Token(Token = "0x4011D1D")]
	public const string ClothesFaceSlotName = "Face";

	[Token(Token = "0x4011D1E")]
	public const string ClothesHairSlotName = "Hair";

	[Token(Token = "0x4011D1F")]
	public const string ClothesSetSlotName = "Set";

	[Token(Token = "0x4011D20")]
	public const string ClothesBagPackSlotName = "BagPack";

	[Token(Token = "0x4011D21")]
	public const string ClothesHeadAdditiveSlotName = "HeadAdditive";

	[Token(Token = "0x4011D22")]
	public const int ClothesSetTypeValue = 12;

	[Token(Token = "0x4011D23")]
	public const int ClothesHairSlotValue = 11;

	[Token(Token = "0x4011D24")]
	public const int ClothesFaceSlotValue = 8;

	[Token(Token = "0x4011D25")]
	[FieldOffset(Offset = "0x30")]
	private static Dictionary<int, string> m_AvatarSlotDic;

	[Token(Token = "0x4011D26")]
	[FieldOffset(Offset = "0x34")]
	protected static Dictionary<int, string> m_RaceDic;

	[Token(Token = "0x4011D27")]
	[FieldOffset(Offset = "0x38")]
	protected static Dictionary<int, string> m_RaceDicLow;

	[Token(Token = "0x4011D28")]
	public const uint DEFAULT_HAIR_ID = 211000000u;

	[Token(Token = "0x4011D29")]
	public const uint DEFAULT_FACE_ID = 208000000u;

	[Token(Token = "0x4011D2A")]
	public const uint DEFAULT_HEAD_ADDITIVE_ID = 214000000u;

	[Token(Token = "0x1700145C")]
	public static Color FemaleStartColor
	{
		[Token(Token = "0x6013836")]
		[Address(RVA = "0x30BE284", Offset = "0x30BE284", VA = "0x30BE284")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color);
		}
	}

	[Token(Token = "0x1700145D")]
	public static Color AvatarStartColor
	{
		[Token(Token = "0x6013837")]
		[Address(RVA = "0x30BE4C8", Offset = "0x30BE4C8", VA = "0x30BE4C8")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color);
		}
	}

	[Token(Token = "0x1700145E")]
	public static Color AvatarEndColor
	{
		[Token(Token = "0x6013838")]
		[Address(RVA = "0x30BE718", Offset = "0x30BE718", VA = "0x30BE718")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color);
		}
	}

	[Token(Token = "0x6013835")]
	[Address(RVA = "0x30B15C4", Offset = "0x30B15C4", VA = "0x30B15C4")]
	public UIModelAvatarBase()
	{
	}

	[Token(Token = "0x6013839")]
	[Address(RVA = "0x30BE968", Offset = "0x30BE968", VA = "0x30BE968")]
	public static Color GetSkinColor(float v)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601383A")]
	[Address(RVA = "0x30BEAA0", Offset = "0x30BEAA0", VA = "0x30BEAA0")]
	public static Color GetFemaleSkinColor(float v)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601383B")]
	[Address(RVA = "0x30BEC90", Offset = "0x30BEC90", VA = "0x30BEC90")]
	public static Dictionary<int, string> AvatarSlotDict()
	{
		return null;
	}

	[Token(Token = "0x601383C")]
	[Address(RVA = "0x30B4460", Offset = "0x30B4460", VA = "0x30B4460")]
	public static bool IsFemale(uint avatar_id)
	{
		return default(bool);
	}

	[Token(Token = "0x601383D")]
	[Address(RVA = "0x30BED60", Offset = "0x30BED60", VA = "0x30BED60")]
	public static EHairType GetHairType(uint avatar_id)
	{
		return default(EHairType);
	}

	[Token(Token = "0x601383E")]
	[Address(RVA = "0x30B9D0C", Offset = "0x30B9D0C", VA = "0x30B9D0C")]
	public static bool IsDefaultClothesID(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601383F")]
	[Address(RVA = "0x30BEE68", Offset = "0x30BEE68", VA = "0x30BEE68")]
	public static bool IsDefaultClothesWithNoDefaultRecipe(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013840")]
	[Address(RVA = "0x30BEEEC", Offset = "0x30BEEEC", VA = "0x30BEEEC")]
	public static uint GetDefaultClothesID(EWardrobeType slot)
	{
		return default(uint);
	}

	[Token(Token = "0x6013841")]
	[Address(RVA = "0x30BEF7C", Offset = "0x30BEF7C", VA = "0x30BEF7C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}
}
