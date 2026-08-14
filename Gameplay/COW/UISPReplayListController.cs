using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200229A")]
public class UISPReplayListController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x400D8BC")]
	[FieldOffset(Offset = "0x68")]
	private UISPReplayListView m_View;

	[Token(Token = "0x400D8BD")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelReplay m_Model;

	[Token(Token = "0x600BE10")]
	[Address(RVA = "0x14AA668", Offset = "0x14AA668", VA = "0x14AA668")]
	public UISPReplayListController()
	{
	}

	[Token(Token = "0x600BE11")]
	[Address(RVA = "0x14AA6EC", Offset = "0x14AA6EC", VA = "0x14AA6EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE12")]
	[Address(RVA = "0x14AA794", Offset = "0x14AA794", VA = "0x14AA794", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BE13")]
	[Address(RVA = "0x14AACB8", Offset = "0x14AACB8", VA = "0x14AACB8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BE14")]
	[Address(RVA = "0x14AADE8", Offset = "0x14AADE8", VA = "0x14AADE8")]
	private void OnInputChanged()
	{
	}

	[Token(Token = "0x600BE15")]
	[Address(RVA = "0x14AAEF8", Offset = "0x14AAEF8", VA = "0x14AAEF8")]
	private void OnBtnInputClear()
	{
	}

	[Token(Token = "0x600BE16")]
	[Address(RVA = "0x14AB008", Offset = "0x14AB008", VA = "0x14AB008")]
	private void OnBtnRoomSearch()
	{
	}

	[Token(Token = "0x600BE17")]
	[Address(RVA = "0x14AAB90", Offset = "0x14AAB90", VA = "0x14AAB90")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x600BE18")]
	[Address(RVA = "0x14AB05C", Offset = "0x14AB05C", VA = "0x14AB05C", Slot = "44")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600BE19")]
	[Address(RVA = "0x14AB154", Offset = "0x14AB154", VA = "0x14AB154", Slot = "45")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600BE1A")]
	[Address(RVA = "0x14AB1D0", Offset = "0x14AB1D0", VA = "0x14AB1D0", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BE1B")]
	[Address(RVA = "0x14AB29C", Offset = "0x14AB29C", VA = "0x14AB29C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BE1C")]
	[Address(RVA = "0x14AB330", Offset = "0x14AB330", VA = "0x14AB330")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BE1D")]
	[Address(RVA = "0x14AB338", Offset = "0x14AB338", VA = "0x14AB338")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
