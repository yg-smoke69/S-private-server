using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000636")]
public class LevelHotzone : BaseLevelObject
{
	[Token(Token = "0x2000637")]
	public enum GKNGEKBGGMN
	{
		[Token(Token = "0x4004667")]
		SYNC,
		[Token(Token = "0x4004668")]
		DISMISS
	}

	[Token(Token = "0x4004661")]
	[FieldOffset(Offset = "0x74")]
	public string hotzoneName;

	[Token(Token = "0x4004662")]
	[FieldOffset(Offset = "0x78")]
	public string hotzoneNameLoc;

	[Token(Token = "0x4004663")]
	[FieldOffset(Offset = "0x7C")]
	public float radius;

	[Token(Token = "0x4004664")]
	[FieldOffset(Offset = "0x80")]
	public float duration;

	[Token(Token = "0x4004665")]
	[FieldOffset(Offset = "0x84")]
	public CapsuleCollider capCollider;

	[Token(Token = "0x600267F")]
	[Address(RVA = "0x272C078", Offset = "0x272C078", VA = "0x272C078")]
	public LevelHotzone()
	{
	}

	[Token(Token = "0x6002680")]
	[Address(RVA = "0x272C088", Offset = "0x272C088", VA = "0x272C088", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002681")]
	[Address(RVA = "0x272C12C", Offset = "0x272C12C", VA = "0x272C12C", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002682")]
	[Address(RVA = "0x272C220", Offset = "0x272C220", VA = "0x272C220", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002683")]
	[Address(RVA = "0x272C644", Offset = "0x272C644", VA = "0x272C644")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002684")]
	[Address(RVA = "0x272C64C", Offset = "0x272C64C", VA = "0x272C64C")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
