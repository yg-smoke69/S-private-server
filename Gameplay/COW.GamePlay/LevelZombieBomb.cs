using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006F0")]
public class LevelZombieBomb : BaseLevelObject
{
	[Token(Token = "0x4004B7A")]
	[FieldOffset(Offset = "0x74")]
	public IAIWarningRegion mWarningArea;

	[Token(Token = "0x4004B7B")]
	[FieldOffset(Offset = "0x78")]
	public int mAIType;

	[Token(Token = "0x4004B7C")]
	[FieldOffset(Offset = "0x7C")]
	public float mDamageRadius;

	[Token(Token = "0x6002C52")]
	[Address(RVA = "0x2441360", Offset = "0x2441360", VA = "0x2441360")]
	public LevelZombieBomb()
	{
	}

	[Token(Token = "0x6002C53")]
	[Address(RVA = "0x2441368", Offset = "0x2441368", VA = "0x2441368")]
	public static ResourceID GetZombieBombResIdByAIType(int MLAEOEAAOCF)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002C54")]
	[Address(RVA = "0x244146C", Offset = "0x244146C", VA = "0x244146C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002C55")]
	[Address(RVA = "0x2441510", Offset = "0x2441510", VA = "0x2441510")]
	private ResourceID JCNDNLDIMPK()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002C56")]
	[Address(RVA = "0x24415C0", Offset = "0x24415C0", VA = "0x24415C0", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002C57")]
	[Address(RVA = "0x2441A34", Offset = "0x2441A34", VA = "0x2441A34")]
	private void JIFLCFHMKHD()
	{
	}

	[Token(Token = "0x6002C58")]
	[Address(RVA = "0x2441E14", Offset = "0x2441E14", VA = "0x2441E14")]
	private void HANDJAJCCLN(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6002C59")]
	[Address(RVA = "0x2442008", Offset = "0x2442008", VA = "0x2442008")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
