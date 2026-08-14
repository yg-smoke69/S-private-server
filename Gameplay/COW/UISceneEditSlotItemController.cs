using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002356")]
public class UISceneEditSlotItemController : UIEasyListItemController
{
	[Token(Token = "0x2002357")]
	private sealed class _003CWaitForShareAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DC2F")]
		[FieldOffset(Offset = "0x8")]
		internal UISceneEditSlotItemController _0024this;

		[Token(Token = "0x400DC30")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DC31")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DC32")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010C8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C500")]
			[Address(RVA = "0x2DADE28", Offset = "0x2DADE28", VA = "0x2DADE28", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010C9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C501")]
			[Address(RVA = "0x2DADE30", Offset = "0x2DADE30", VA = "0x2DADE30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C4FE")]
		[Address(RVA = "0x2DADB7C", Offset = "0x2DADB7C", VA = "0x2DADB7C")]
		public _003CWaitForShareAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C4FF")]
		[Address(RVA = "0x2DADD0C", Offset = "0x2DADD0C", VA = "0x2DADD0C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C502")]
		[Address(RVA = "0x2DADE38", Offset = "0x2DADE38", VA = "0x2DADE38", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C503")]
		[Address(RVA = "0x2DADE4C", Offset = "0x2DADE4C", VA = "0x2DADE4C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DC2A")]
	[FieldOffset(Offset = "0x38")]
	private UISceneEditSlotItemView m_View;

	[Token(Token = "0x400DC2B")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Index;

	[Token(Token = "0x400DC2C")]
	[FieldOffset(Offset = "0x40")]
	private uint m_SlotID;

	[Token(Token = "0x400DC2D")]
	[FieldOffset(Offset = "0x44")]
	private EWorkshop.SlotType m_SlotType;

	[Token(Token = "0x400DC2E")]
	[FieldOffset(Offset = "0x48")]
	private EWorkshop.SlotState m_SlotState;

	[Token(Token = "0x600C4EB")]
	[Address(RVA = "0x2DAC2FC", Offset = "0x2DAC2FC", VA = "0x2DAC2FC")]
	public UISceneEditSlotItemController()
	{
	}

	[Token(Token = "0x600C4EC")]
	[Address(RVA = "0x2DAC304", Offset = "0x2DAC304", VA = "0x2DAC304")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C4ED")]
	[Address(RVA = "0x2DAC3A8", Offset = "0x2DAC3A8", VA = "0x2DAC3A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C4EE")]
	[Address(RVA = "0x2DAC6C4", Offset = "0x2DAC6C4", VA = "0x2DAC6C4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C4EF")]
	[Address(RVA = "0x2DAC76C", Offset = "0x2DAC76C", VA = "0x2DAC76C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C4F0")]
	[Address(RVA = "0x2DACDB4", Offset = "0x2DACDB4", VA = "0x2DACDB4", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600C4F1")]
	[Address(RVA = "0x2DACE50", Offset = "0x2DACE50", VA = "0x2DACE50", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C4F2")]
	[Address(RVA = "0x2DAD8E8", Offset = "0x2DAD8E8", VA = "0x2DAD8E8")]
	public void PlayUploadAnim()
	{
	}

	[Token(Token = "0x600C4F3")]
	[Address(RVA = "0x2DAD978", Offset = "0x2DAD978", VA = "0x2DAD978")]
	public void PlayDownloadAnim()
	{
	}

	[Token(Token = "0x600C4F4")]
	[Address(RVA = "0x2DADA08", Offset = "0x2DADA08", VA = "0x2DADA08")]
	public void PlayShareAnim()
	{
	}

	[Token(Token = "0x600C4F5")]
	[Address(RVA = "0x2DAD590", Offset = "0x2DAD590", VA = "0x2DAD590")]
	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x600C4F6")]
	[Address(RVA = "0x2DADAB0", Offset = "0x2DADAB0", VA = "0x2DADAB0")]
	private IEnumerator WaitForShareAnim()
	{
		return null;
	}

	[Token(Token = "0x600C4F7")]
	[Address(RVA = "0x2DADB84", Offset = "0x2DADB84", VA = "0x2DADB84")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600C4F8")]
	[Address(RVA = "0x2DADBC8", Offset = "0x2DADBC8", VA = "0x2DADBC8")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x600C4F9")]
	[Address(RVA = "0x2DADC0C", Offset = "0x2DADC0C", VA = "0x2DADC0C")]
	private void _003CRefreshCDNMapIcon_003Em__2()
	{
	}

	[Token(Token = "0x600C4FA")]
	[Address(RVA = "0x2DADCEC", Offset = "0x2DADCEC", VA = "0x2DADCEC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C4FB")]
	[Address(RVA = "0x2DADCF4", Offset = "0x2DADCF4", VA = "0x2DADCF4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600C4FC")]
	[Address(RVA = "0x2DADCFC", Offset = "0x2DADCFC", VA = "0x2DADCFC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C4FD")]
	[Address(RVA = "0x2DADD04", Offset = "0x2DADD04", VA = "0x2DADD04")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
