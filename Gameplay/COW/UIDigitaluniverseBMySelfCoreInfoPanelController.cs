using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EE3")]
public class UIDigitaluniverseBMySelfCoreInfoPanelController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C280")]
	[FieldOffset(Offset = "0x48")]
	private UIDigitaluniverseBMySelfCoreInfoPanelView m_View;

	[Token(Token = "0x400C281")]
	private const float m_HeightSpace = 40f;

	[Token(Token = "0x400C282")]
	[FieldOffset(Offset = "0x4C")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400C283")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_Pos;

	[Token(Token = "0x400C284")]
	[FieldOffset(Offset = "0x60")]
	private ulong m_AccountId;

	[Token(Token = "0x400C285")]
	[FieldOffset(Offset = "0x68")]
	private string m_NickName;

	[Token(Token = "0x400C286")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_IsSignWordChanged;

	[Token(Token = "0x400C287")]
	[FieldOffset(Offset = "0x70")]
	private UIModelDigitaluniverseB m_DigitaluniverseBModel;

	[Token(Token = "0x60096B0")]
	[Address(RVA = "0x2F801A0", Offset = "0x2F801A0", VA = "0x2F801A0")]
	public UIDigitaluniverseBMySelfCoreInfoPanelController()
	{
	}

	[Token(Token = "0x60096B1")]
	[Address(RVA = "0x2F801A8", Offset = "0x2F801A8", VA = "0x2F801A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60096B2")]
	[Address(RVA = "0x2F80250", Offset = "0x2F80250", VA = "0x2F80250", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60096B3")]
	[Address(RVA = "0x2F80588", Offset = "0x2F80588", VA = "0x2F80588")]
	public void SetViewData(Vector3 Pos, ulong accountId, string nickName)
	{
	}

	[Token(Token = "0x60096B4")]
	[Address(RVA = "0x2F80DF0", Offset = "0x2F80DF0", VA = "0x2F80DF0", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x60096B5")]
	[Address(RVA = "0x2F80714", Offset = "0x2F80714", VA = "0x2F80714")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60096B6")]
	[Address(RVA = "0x2F81204", Offset = "0x2F81204", VA = "0x2F81204")]
	private void OnMaskBtnClick()
	{
	}

	[Token(Token = "0x60096B7")]
	[Address(RVA = "0x2F81598", Offset = "0x2F81598", VA = "0x2F81598")]
	private void OnInputChange()
	{
	}

	[Token(Token = "0x60096B8")]
	[Address(RVA = "0x2F80E48", Offset = "0x2F80E48", VA = "0x2F80E48")]
	private void SetPosition(Vector3 itemPos)
	{
	}

	[Token(Token = "0x60096B9")]
	[Address(RVA = "0x2F815F4", Offset = "0x2F815F4", VA = "0x2F815F4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60096BA")]
	[Address(RVA = "0x2F81694", Offset = "0x2F81694", VA = "0x2F81694", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60096BB")]
	[Address(RVA = "0x2F816F8", Offset = "0x2F816F8", VA = "0x2F816F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60096BC")]
	[Address(RVA = "0x2F81700", Offset = "0x2F81700", VA = "0x2F81700")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
