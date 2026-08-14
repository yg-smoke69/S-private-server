using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002BF4")]
public class UIVeteranTaskController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x2002BF5")]
	private sealed class _003COnUIInit_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010C8C")]
		[FieldOffset(Offset = "0x8")]
		internal int Id;

		[Token(Token = "0x4010C8D")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranTaskController _0024this;

		[Token(Token = "0x60123A7")]
		[Address(RVA = "0x2CC72FC", Offset = "0x2CC72FC", VA = "0x2CC72FC")]
		public _003COnUIInit_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60123A8")]
		[Address(RVA = "0x2CC8978", Offset = "0x2CC8978", VA = "0x2CC8978")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4010C80")]
	[FieldOffset(Offset = "0x28")]
	private UIModelVeteranSignin m_VeteranModel;

	[Token(Token = "0x4010C81")]
	[FieldOffset(Offset = "0x2C")]
	private UIVeteranTaskView m_View;

	[Token(Token = "0x4010C82")]
	private const string PROGRESS_FORMAT = "{0}/{1}";

	[Token(Token = "0x4010C83")]
	[FieldOffset(Offset = "0x30")]
	private BaseItemInfo m_RewardInfo;

	[Token(Token = "0x4010C84")]
	[FieldOffset(Offset = "0x34")]
	private List<UIStandardItemMiniController> m_VeteranTaskRewardList;

	[Token(Token = "0x4010C85")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> m_FinishLightList;

	[Token(Token = "0x4010C86")]
	[FieldOffset(Offset = "0x3C")]
	private List<GameObject> m_UnFinishLigthList;

	[Token(Token = "0x4010C87")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> m_RareRewardList;

	[Token(Token = "0x4010C88")]
	[FieldOffset(Offset = "0x44")]
	private List<UIButton> m_ClaimBtnList;

	[Token(Token = "0x4010C89")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<ClientVeteranTaskDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010C8A")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<ClientVeteranTaskDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4010C8B")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<ClientVeteranTaskDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x6012397")]
	[Address(RVA = "0x2CC64CC", Offset = "0x2CC64CC", VA = "0x2CC64CC")]
	public UIVeteranTaskController()
	{
	}

	[Token(Token = "0x6012398")]
	[Address(RVA = "0x2CC6584", Offset = "0x2CC6584", VA = "0x2CC6584")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012399")]
	[Address(RVA = "0x2CC6628", Offset = "0x2CC6628", VA = "0x2CC6628", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601239A")]
	[Address(RVA = "0x2CC7D24", Offset = "0x2CC7D24", VA = "0x2CC7D24", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601239B")]
	[Address(RVA = "0x2CC7DAC", Offset = "0x2CC7DAC", VA = "0x2CC7DAC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601239C")]
	[Address(RVA = "0x2CC7E40", Offset = "0x2CC7E40", VA = "0x2CC7E40", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601239D")]
	[Address(RVA = "0x2CC7304", Offset = "0x2CC7304", VA = "0x2CC7304")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x601239E")]
	[Address(RVA = "0x2CC7F5C", Offset = "0x2CC7F5C", VA = "0x2CC7F5C")]
	private void UpdateClaimInfo()
	{
	}

	[Token(Token = "0x601239F")]
	[Address(RVA = "0x2CC8600", Offset = "0x2CC8600", VA = "0x2CC8600", Slot = "33")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60123A0")]
	[Address(RVA = "0x2CC86F8", Offset = "0x2CC86F8", VA = "0x2CC86F8", Slot = "34")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60123A1")]
	[Address(RVA = "0x2CC8774", Offset = "0x2CC8774", VA = "0x2CC8774")]
	private static int _003CUpdateView_003Em__0(ClientVeteranTaskDesc x, ClientVeteranTaskDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x60123A2")]
	[Address(RVA = "0x2CC87B4", Offset = "0x2CC87B4", VA = "0x2CC87B4")]
	private static int _003CUpdateView_003Em__1(ClientVeteranTaskDesc x, ClientVeteranTaskDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x60123A3")]
	[Address(RVA = "0x2CC87F4", Offset = "0x2CC87F4", VA = "0x2CC87F4")]
	private static int _003CUpdateView_003Em__2(ClientVeteranTaskDesc x, ClientVeteranTaskDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x60123A4")]
	[Address(RVA = "0x2CC8834", Offset = "0x2CC8834", VA = "0x2CC8834")]
	private void _003CUpdateView_003Em__3(Texture texture)
	{
	}

	[Token(Token = "0x60123A5")]
	[Address(RVA = "0x2CC8968", Offset = "0x2CC8968", VA = "0x2CC8968")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60123A6")]
	[Address(RVA = "0x2CC8970", Offset = "0x2CC8970", VA = "0x2CC8970")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
