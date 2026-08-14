using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20000E6")]
public class WeaponSkinData : CsvDataIndexedReading
{
	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x8")]
	public bool MaxShow;

	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 MaxPosition;

	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 MaxRotatiton;

	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 MaxScale;

	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x30")]
	public uint iID;

	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x34")]
	public uint WeaponID;

	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x38")]
	public uint LabelID;

	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0x3C")]
	public uint AnimationID;

	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x40")]
	public uint sortId;

	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x44")]
	public uint Announcement;

	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x48")]
	public uint WeaponSet;

	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0x4C")]
	public uint SkinLevel;

	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x50")]
	public ResourceID previewRes;

	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0x54")]
	public ResourceID inGameRes3P;

	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0x58")]
	public ResourceID inGameRes1P;

	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0x5C")]
	public ResourceID inGameRes3PSecond;

	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x60")]
	public ResourceID inGameRes1PSecond;

	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0x64")]
	public ResourceID BackRes;

	[Token(Token = "0x40005AF")]
	[FieldOffset(Offset = "0x68")]
	public ResourceID BackResSecond;

	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x6C")]
	public ResourceID previewEffectRes;

	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x70")]
	public ResourceID ParticleRes;

	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x74")]
	public ResourceID ParticleResSecond;

	[Token(Token = "0x40005B3")]
	[FieldOffset(Offset = "0x78")]
	public ResourceID FireEffect;

	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x7C")]
	public ResourceID FireSound;

	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x80")]
	public ResourceID PVEIconResID;

	[Token(Token = "0x40005B6")]
	[FieldOffset(Offset = "0x84")]
	public ResourceID AnnouncementType;

	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x88")]
	public ResourceID CampIcon;

	[Token(Token = "0x40005B8")]
	[FieldOffset(Offset = "0x8C")]
	public ResourceID PreviewShootEffect;

	[Token(Token = "0x40005B9")]
	[FieldOffset(Offset = "0x90")]
	public ResourceID PreviewHitEffect;

	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x94")]
	public ResourceID IngameHitEffect;

	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x98")]
	public ResourceID PreviewKillEffect;

	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x9C")]
	public ResourceID IngameKillEffect;

	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0xA0")]
	public ResourceID FullScreenEffect;

	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0xA4")]
	public ResourceID PreviewGunTraceEffect;

	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0xA8")]
	public ResourceID IngameGunTraceEffect;

	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0xAC")]
	public bool IsWithEffect;

	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0xAD")]
	public bool IsShow;

	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0xAE")]
	public bool IsPVE_WeaponSkin;

	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0xAF")]
	public bool IsDoubleWeapon;

	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0xB0")]
	public bool FistUseForeArm;

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x21A69B8", Offset = "0x21A69B8", VA = "0x21A69B8")]
	public WeaponSkinData()
	{
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x21A6BE4", Offset = "0x21A6BE4", VA = "0x21A6BE4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x21A6C48", Offset = "0x21A6C48", VA = "0x21A6C48", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x21A7F30", Offset = "0x21A7F30", VA = "0x21A7F30", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x21AA9A0", Offset = "0x21AA9A0", VA = "0x21AA9A0")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x21AA9A8", Offset = "0x21AA9A8", VA = "0x21AA9A8")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
