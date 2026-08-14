using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024DA")]
public class UIAvatarSuitListController : UIBaseController, _Attribute
{
	[Token(Token = "0x20024DB")]
	private sealed class _003CCoResetClothes_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E481")]
		[FieldOffset(Offset = "0x8")]
		internal UIAvatarSuitListController _0024this;

		[Token(Token = "0x400E482")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400E483")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400E484")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001139")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D435")]
			[Address(RVA = "0x2FA4640", Offset = "0x2FA4640", VA = "0x2FA4640", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700113A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D436")]
			[Address(RVA = "0x2FA4648", Offset = "0x2FA4648", VA = "0x2FA4648", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D433")]
		[Address(RVA = "0x2FA459C", Offset = "0x2FA459C", VA = "0x2FA459C")]
		public _003CCoResetClothes_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600D434")]
		[Address(RVA = "0x2FA45B4", Offset = "0x2FA45B4", VA = "0x2FA45B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D437")]
		[Address(RVA = "0x2FA4650", Offset = "0x2FA4650", VA = "0x2FA4650", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D438")]
		[Address(RVA = "0x2FA4664", Offset = "0x2FA4664", VA = "0x2FA4664", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E47D")]
	[FieldOffset(Offset = "0x28")]
	private uint m_CurrentSuitID;

	[Token(Token = "0x400E47E")]
	[FieldOffset(Offset = "0x2C")]
	private UIAvatarSuitListView m_View;

	[Token(Token = "0x400E47F")]
	[FieldOffset(Offset = "0x30")]
	private uint m_AvatarID;

	[Token(Token = "0x400E480")]
	[FieldOffset(Offset = "0x34")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x600D425")]
	[Address(RVA = "0x2FA3574", Offset = "0x2FA3574", VA = "0x2FA3574")]
	public UIAvatarSuitListController()
	{
	}

	[Token(Token = "0x600D426")]
	[Address(RVA = "0x2FA35F8", Offset = "0x2FA35F8", VA = "0x2FA35F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D427")]
	[Address(RVA = "0x2FA369C", Offset = "0x2FA369C", VA = "0x2FA369C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D428")]
	[Address(RVA = "0x2FA39A0", Offset = "0x2FA39A0", VA = "0x2FA39A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D429")]
	[Address(RVA = "0x2FA3B3C", Offset = "0x2FA3B3C", VA = "0x2FA3B3C")]
	public void SetData(uint AvatarID, uint curSuitID)
	{
	}

	[Token(Token = "0x600D42A")]
	[Address(RVA = "0x2FA3BC4", Offset = "0x2FA3BC4", VA = "0x2FA3BC4")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x600D42B")]
	[Address(RVA = "0x2FA40D0", Offset = "0x2FA40D0", VA = "0x2FA40D0")]
	public void OnSwitchSuit(object[] param)
	{
	}

	[Token(Token = "0x600D42C")]
	[Address(RVA = "0x2FA41D8", Offset = "0x2FA41D8", VA = "0x2FA41D8")]
	public void OnSuitChanged(object[] param)
	{
	}

	[Token(Token = "0x600D42D")]
	[Address(RVA = "0x2FA4240", Offset = "0x2FA4240", VA = "0x2FA4240", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D42E")]
	[Address(RVA = "0x2FA4338", Offset = "0x2FA4338", VA = "0x2FA4338", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D42F")]
	[Address(RVA = "0x2FA43B4", Offset = "0x2FA43B4", VA = "0x2FA43B4")]
	public void OnResetClothesClick()
	{
	}

	[Token(Token = "0x600D430")]
	[Address(RVA = "0x2FA44D0", Offset = "0x2FA44D0", VA = "0x2FA44D0")]
	private IEnumerator CoResetClothes()
	{
		return null;
	}

	[Token(Token = "0x600D431")]
	[Address(RVA = "0x2FA45A4", Offset = "0x2FA45A4", VA = "0x2FA45A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D432")]
	[Address(RVA = "0x2FA45AC", Offset = "0x2FA45AC", VA = "0x2FA45AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
