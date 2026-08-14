using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003800")]
public class UIIntegrationTestView : UIBaseView
{
	[Token(Token = "0x4016C00")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TestMain;

	[Token(Token = "0x4016C01")]
	[FieldOffset(Offset = "0x18")]
	public UITable2 TestTable;

	[Token(Token = "0x6016BAB")]
	[Address(RVA = "0x1281DBC", Offset = "0x1281DBC", VA = "0x1281DBC")]
	public UIIntegrationTestView()
	{
	}

	[Token(Token = "0x6016BAC")]
	[Address(RVA = "0x1281DC4", Offset = "0x1281DC4", VA = "0x1281DC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BAD")]
	[Address(RVA = "0x1281FC0", Offset = "0x1281FC0", VA = "0x1281FC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
