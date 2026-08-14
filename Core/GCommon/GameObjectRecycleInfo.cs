using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003ECC")]
public class GameObjectRecycleInfo : ObjectPoolCallbackBase
{
	[Token(Token = "0x401A850")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_GameObject;

	[Token(Token = "0x401A851")]
	[FieldOffset(Offset = "0x10")]
	private Transform m_Parent;

	[Token(Token = "0x401A852")]
	[FieldOffset(Offset = "0x14")]
	private bool m_Actived;

	[Token(Token = "0x60198FD")]
	[Address(RVA = "0x32B58B4", Offset = "0x32B58B4", VA = "0x32B58B4")]
	public GameObjectRecycleInfo()
	{
	}

	[Token(Token = "0x60198FE")]
	[Address(RVA = "0x32B5554", Offset = "0x32B5554", VA = "0x32B5554")]
	public void Recycle(GameObject go, Transform binRoot)
	{
	}

	[Token(Token = "0x60198FF")]
	[Address(RVA = "0x32B52A8", Offset = "0x32B52A8", VA = "0x32B52A8")]
	public void Restore()
	{
	}

	[Token(Token = "0x6019900")]
	[Address(RVA = "0x32B58BC", Offset = "0x32B58BC", VA = "0x32B58BC", Slot = "8")]
	public override void OnCollected()
	{
	}
}
