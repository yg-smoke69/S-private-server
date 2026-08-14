using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F0")]
public class UIDispatchTaskView : UIBaseView
{
	[Token(Token = "0x4014CFA")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture TitleCDN;

	[Token(Token = "0x4014CFB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RuleButton;

	[Token(Token = "0x4014CFC")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid TasksList;

	[Token(Token = "0x4014CFD")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture BGTexture;

	[Token(Token = "0x4014CFE")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnClose;

	[Token(Token = "0x6016280")]
	[Address(RVA = "0x275E530", Offset = "0x275E530", VA = "0x275E530")]
	public UIDispatchTaskView()
	{
	}

	[Token(Token = "0x6016281")]
	[Address(RVA = "0x275E538", Offset = "0x275E538", VA = "0x275E538", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016282")]
	[Address(RVA = "0x275E77C", Offset = "0x275E77C", VA = "0x275E77C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
