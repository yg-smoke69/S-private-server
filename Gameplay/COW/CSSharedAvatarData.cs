using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000106")]
public class CSSharedAvatarData : CSVBaseData
{
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0xC")]
	public int sortID;

	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x10")]
	public int gender;

	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x14")]
	public bool isDefault;

	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x15")]
	public bool isSelected;

	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID resIcon;

	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] wardrobeType;

	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x20")]
	public string[] recipeStrInGame;

	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x24")]
	public string[] recipeStrInLobby;

	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0x28")]
	public string description;

	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x2C")]
	public string name;

	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x30")]
	public string introduction;

	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x34")]
	public ResourceID resAnimation;

	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x38")]
	public ResourceID resWalkAnimation;

	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x3C")]
	public ResourceID resAvatar;

	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x40")]
	public ResourceID portrait;

	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x44")]
	public ResourceID sharePortrait;

	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x48")]
	public ResourceID DecorPropIDRoot;

	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x4C")]
	public ResourceID DecorPropIDLeft;

	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x50")]
	public ResourceID DecorPropIDRight;

	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x54")]
	public ResourceID inGameSpecialAnim;

	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x58")]
	public Color defaultSkinColor;

	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x68")]
	public uint avatarSkillSlotID;

	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x6C")]
	public bool canChangeSkinColor;

	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x6D")]
	public bool isSpecialCharacter;

	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x70")]
	public int animationInterval;

	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x74")]
	public int hairType;

	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x78")]
	public uint bundleID;

	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x7C")]
	public uint luxuryBundleID;

	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x80")]
	public ResourceID AlignmentIcon;

	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x84")]
	public string AlignmentDesc;

	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x88")]
	public string AlignmentName;

	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x8C")]
	public uint pvePrimaryWeapon;

	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x90")]
	public bool HeadAdditiveSwitch;

	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x91")]
	public bool IsActiveSkill;

	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x92")]
	public bool EnableEyesLookAt;

	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0x94")]
	public UIModelAvatarBase.EAvatarType AvatarType;

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x1822318", Offset = "0x1822318", VA = "0x1822318")]
	public CSSharedAvatarData()
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x1822488", Offset = "0x1822488", VA = "0x1822488")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x18224E0", Offset = "0x18224E0", VA = "0x18224E0")]
	public bool IsFemale()
	{
		return default(bool);
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0x1822544", Offset = "0x1822544", VA = "0x1822544", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0x18225A8", Offset = "0x18225A8", VA = "0x18225A8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
