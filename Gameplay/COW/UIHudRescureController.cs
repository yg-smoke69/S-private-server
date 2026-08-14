using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002834")]
internal class UIHudRescureController : UIBaseController
{
	[Token(Token = "0x400F80E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRescureView m_View;

	[Token(Token = "0x400F80F")]
	[FieldOffset(Offset = "0x30")]
	private IHAAMHPPLMG m_TargetResureID;

	[Token(Token = "0x400F810")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 diffPos;

	[Token(Token = "0x400F811")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 currentPos;

	[Token(Token = "0x400F812")]
	[FieldOffset(Offset = "0x60")]
	private Transform tr;

	[Token(Token = "0x400F813")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsRescuring;

	[Token(Token = "0x600FABE")]
	[Address(RVA = "0x13EDCB8", Offset = "0x13EDCB8", VA = "0x13EDCB8")]
	public UIHudRescureController()
	{
	}

	[Token(Token = "0x600FABF")]
	[Address(RVA = "0x13EDD98", Offset = "0x13EDD98", VA = "0x13EDD98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FAC0")]
	[Address(RVA = "0x13EDE3C", Offset = "0x13EDE3C", VA = "0x13EDE3C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FAC1")]
	[Address(RVA = "0x13EE218", Offset = "0x13EE218", VA = "0x13EE218", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FAC2")]
	[Address(RVA = "0x13EE4BC", Offset = "0x13EE4BC", VA = "0x13EE4BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600FAC3")]
	[Address(RVA = "0x13F02C0", Offset = "0x13F02C0", VA = "0x13F02C0")]
	public void ModifyRescurePos(Vector3 pos)
	{
	}

	[Token(Token = "0x600FAC4")]
	[Address(RVA = "0x13F0404", Offset = "0x13F0404", VA = "0x13F0404")]
	public void SetChangePos(Vector3 pos)
	{
	}

	[Token(Token = "0x600FAC5")]
	[Address(RVA = "0x13F048C", Offset = "0x13F048C", VA = "0x13F048C")]
	private void OnRescureBtnClicked()
	{
	}

	[Token(Token = "0x600FAC6")]
	[Address(RVA = "0x13F0868", Offset = "0x13F0868", VA = "0x13F0868")]
	private void OnPreparationCancel(object[] param)
	{
	}

	[Token(Token = "0x600FAC7")]
	[Address(RVA = "0x13F0A28", Offset = "0x13F0A28", VA = "0x13F0A28")]
	private void OnHudSettingChanged(object[] param)
	{
	}

	[Token(Token = "0x600FAC8")]
	[Address(RVA = "0x13F0B98", Offset = "0x13F0B98", VA = "0x13F0B98")]
	private void OnDecreaseInPreparation(object[] data)
	{
	}

	[Token(Token = "0x600FAC9")]
	[Address(RVA = "0x13F0CB4", Offset = "0x13F0CB4", VA = "0x13F0CB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FACA")]
	[Address(RVA = "0x13F0CBC", Offset = "0x13F0CBC", VA = "0x13F0CBC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
