using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20006D9")]
public class LevelUGCSpawnPos : BaseAutoGenIDLevelObject
{
	[Token(Token = "0x4004B07")]
	[FieldOffset(Offset = "0x74")]
	public Transform[] points;

	[Token(Token = "0x4004B08")]
	[FieldOffset(Offset = "0x78")]
	public LevelDynamicCollider dynamicCollider;

	[Token(Token = "0x6002BB9")]
	[Address(RVA = "0xEBFFD4", Offset = "0xEBFFD4", VA = "0xEBFFD4")]
	public LevelUGCSpawnPos()
	{
	}

	[Token(Token = "0x6002BBA")]
	[Address(RVA = "0xEBFFDC", Offset = "0xEBFFDC", VA = "0xEBFFDC", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002BBB")]
	[Address(RVA = "0xEC0080", Offset = "0xEC0080", VA = "0xEC0080", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002BBC")]
	[Address(RVA = "0xEC0100", Offset = "0xEC0100", VA = "0xEC0100", Slot = "31")]
	public override void SyncAction(object[] param)
	{
	}

	[Token(Token = "0x6002BBD")]
	[Address(RVA = "0xEC02A8", Offset = "0xEC02A8", VA = "0xEC02A8")]
	private void DoUgcLevelObjectDel()
	{
	}

	[Token(Token = "0x6002BBE")]
	[Address(RVA = "0xEC03A4", Offset = "0xEC03A4", VA = "0xEC03A4")]
	private void DoUgcLevelObjectAdd(object[] data)
	{
	}

	[Token(Token = "0x6002BBF")]
	[Address(RVA = "0xEC0400", Offset = "0xEC0400", VA = "0xEC0400")]
	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002BC0")]
	[Address(RVA = "0xEC0408", Offset = "0xEC0408", VA = "0xEC0408")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002BC1")]
	[Address(RVA = "0xEC0410", Offset = "0xEC0410", VA = "0xEC0410")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
