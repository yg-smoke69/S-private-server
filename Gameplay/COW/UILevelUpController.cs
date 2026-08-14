using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002908")]
public class UILevelUpController : UIPopupWindowController
{
	[Token(Token = "0x2002909")]
	private sealed class _003COpenChestCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FCBA")]
		[FieldOffset(Offset = "0x8")]
		internal UILevelUpController _0024this;

		[Token(Token = "0x400FCBB")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400FCBC")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400FCBD")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001214")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601043D")]
			[Address(RVA = "0x254D90C", Offset = "0x254D90C", VA = "0x254D90C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001215")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601043E")]
			[Address(RVA = "0x254D914", Offset = "0x254D914", VA = "0x254D914", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601043B")]
		[Address(RVA = "0x254C4EC", Offset = "0x254C4EC", VA = "0x254C4EC")]
		public _003COpenChestCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601043C")]
		[Address(RVA = "0x254D7C0", Offset = "0x254D7C0", VA = "0x254D7C0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601043F")]
		[Address(RVA = "0x254D91C", Offset = "0x254D91C", VA = "0x254D91C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010440")]
		[Address(RVA = "0x254D930", Offset = "0x254D930", VA = "0x254D930", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FCAF")]
	[FieldOffset(Offset = "0x48")]
	private UILevelUpView m_View;

	[Token(Token = "0x400FCB0")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_ChestId;

	[Token(Token = "0x400FCB1")]
	[FieldOffset(Offset = "0x50")]
	private Transform[] m_AwardGridArray;

	[Token(Token = "0x400FCB2")]
	[FieldOffset(Offset = "0x54")]
	private List<CommonRewardItemInfo> m_RewardInfoList;

	[Token(Token = "0x400FCB3")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_ModelChest;

	[Token(Token = "0x400FCB4")]
	[FieldOffset(Offset = "0x5C")]
	private bool isNullNewEntrance;

	[Token(Token = "0x400FCB5")]
	[FieldOffset(Offset = "0x60")]
	private List<UIStandardItemMAXBController> itemCtrlList;

	[Token(Token = "0x400FCB6")]
	[FieldOffset(Offset = "0x64")]
	private int soundCnt;

	[Token(Token = "0x400FCB7")]
	[FieldOffset(Offset = "0x68")]
	private uint m_DelayCall;

	[Token(Token = "0x400FCB8")]
	[FieldOffset(Offset = "0x6C")]
	private string m_CurInAnim;

	[Token(Token = "0x400FCB9")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010420")]
	[Address(RVA = "0x254A8D0", Offset = "0x254A8D0", VA = "0x254A8D0")]
	public UILevelUpController()
	{
	}

	[Token(Token = "0x6010421")]
	[Address(RVA = "0x254A9A4", Offset = "0x254A9A4", VA = "0x254A9A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010422")]
	[Address(RVA = "0x254AA48", Offset = "0x254AA48", VA = "0x254AA48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010423")]
	[Address(RVA = "0x254B064", Offset = "0x254B064", VA = "0x254B064", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010424")]
	[Address(RVA = "0x254B23C", Offset = "0x254B23C", VA = "0x254B23C")]
	public void SetLevelData(uint before, uint next, List<BaseItemInfo> list)
	{
	}

	[Token(Token = "0x6010425")]
	[Address(RVA = "0x254BCFC", Offset = "0x254BCFC", VA = "0x254BCFC")]
	private void OnBtnShowChestClick()
	{
	}

	[Token(Token = "0x6010426")]
	[Address(RVA = "0x254BDCC", Offset = "0x254BDCC", VA = "0x254BDCC")]
	private void RequstToOpenChest()
	{
	}

	[Token(Token = "0x6010427")]
	[Address(RVA = "0x254C050", Offset = "0x254C050", VA = "0x254C050", Slot = "43")]
	public override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x6010428")]
	[Address(RVA = "0x254C16C", Offset = "0x254C16C", VA = "0x254C16C")]
	private void CreateChest()
	{
	}

	[Token(Token = "0x6010429")]
	[Address(RVA = "0x254C420", Offset = "0x254C420", VA = "0x254C420")]
	private IEnumerator OpenChestCoroutine()
	{
		return null;
	}

	[Token(Token = "0x601042A")]
	[Address(RVA = "0x254C4F4", Offset = "0x254C4F4", VA = "0x254C4F4")]
	public void ShowChestReward()
	{
	}

	[Token(Token = "0x601042B")]
	[Address(RVA = "0x254C888", Offset = "0x254C888", VA = "0x254C888", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601042C")]
	[Address(RVA = "0x254CA00", Offset = "0x254CA00", VA = "0x254CA00")]
	private void OnOKClick()
	{
	}

	[Token(Token = "0x601042D")]
	[Address(RVA = "0x254CBE0", Offset = "0x254CBE0", VA = "0x254CBE0")]
	private void OnReceiveAnimEvent(object[] param)
	{
	}

	[Token(Token = "0x601042E")]
	[Address(RVA = "0x254CF18", Offset = "0x254CF18", VA = "0x254CF18")]
	private void OnShowRewardItemVFX()
	{
	}

	[Token(Token = "0x601042F")]
	[Address(RVA = "0x254D0C0", Offset = "0x254D0C0", VA = "0x254D0C0")]
	private void OnPlayRewardAudio(string audioName)
	{
	}

	[Token(Token = "0x6010430")]
	[Address(RVA = "0x254D2F0", Offset = "0x254D2F0", VA = "0x254D2F0", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x6010431")]
	[Address(RVA = "0x254D348", Offset = "0x254D348", VA = "0x254D348", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6010432")]
	[Address(RVA = "0x254D52C", Offset = "0x254D52C", VA = "0x254D52C")]
	private void _003CRequstToOpenChest_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6010433")]
	[Address(RVA = "0x254D724", Offset = "0x254D724", VA = "0x254D724")]
	private void _003CCreateChest_003Em__1()
	{
	}

	[Token(Token = "0x6010434")]
	[Address(RVA = "0x254D788", Offset = "0x254D788", VA = "0x254D788")]
	private static CommonRewardItemInfo _003CRequstToOpenChest_003Em__2(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x6010435")]
	[Address(RVA = "0x254D790", Offset = "0x254D790", VA = "0x254D790")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010436")]
	[Address(RVA = "0x254D798", Offset = "0x254D798", VA = "0x254D798")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010437")]
	[Address(RVA = "0x254D7A0", Offset = "0x254D7A0", VA = "0x254D7A0")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x6010438")]
	[Address(RVA = "0x254D7A8", Offset = "0x254D7A8", VA = "0x254D7A8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010439")]
	[Address(RVA = "0x254D7B0", Offset = "0x254D7B0", VA = "0x254D7B0")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x601043A")]
	[Address(RVA = "0x254D7B8", Offset = "0x254D7B8", VA = "0x254D7B8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
