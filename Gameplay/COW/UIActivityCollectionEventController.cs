using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F51")]
public class UIActivityCollectionEventController : UIActivityContentController, _Attribute
{
	[Token(Token = "0x2001F52")]
	private sealed class _003COnEnableRoutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C4D6")]
		[FieldOffset(Offset = "0x8")]
		internal UIActivityCollectionEventController _0024this;

		[Token(Token = "0x400C4D7")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C4D8")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C4D9")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000F93")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009AEC")]
			[Address(RVA = "0x2A0B434", Offset = "0x2A0B434", VA = "0x2A0B434", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F94")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009AED")]
			[Address(RVA = "0x2A0B43C", Offset = "0x2A0B43C", VA = "0x2A0B43C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009AEA")]
		[Address(RVA = "0x2A0A674", Offset = "0x2A0A674", VA = "0x2A0A674")]
		public _003COnEnableRoutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009AEB")]
		[Address(RVA = "0x2A0B358", Offset = "0x2A0B358", VA = "0x2A0B358", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009AEE")]
		[Address(RVA = "0x2A0B444", Offset = "0x2A0B444", VA = "0x2A0B444", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009AEF")]
		[Address(RVA = "0x2A0B458", Offset = "0x2A0B458", VA = "0x2A0B458", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C4CE")]
	[FieldOffset(Offset = "0x28")]
	private List<UIActivityCollectionSigninItemController> m_ItemList;

	[Token(Token = "0x400C4CF")]
	[FieldOffset(Offset = "0x2C")]
	private UIActivityCollectionEventView m_View;

	[Token(Token = "0x400C4D0")]
	[FieldOffset(Offset = "0x30")]
	private ActivityGroupDesc m_GroupDesc;

	[Token(Token = "0x400C4D1")]
	[FieldOffset(Offset = "0x34")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C4D2")]
	[FieldOffset(Offset = "0x38")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400C4D3")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIActivityExchangeItemController> m_ExchangeDescUIs;

	[Token(Token = "0x400C4D4")]
	[FieldOffset(Offset = "0x40")]
	private int m_ADWidth;

	[Token(Token = "0x400C4D5")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<UIActivityCollectionSigninItemController> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6009ACD")]
	[Address(RVA = "0x2A06DC4", Offset = "0x2A06DC4", VA = "0x2A06DC4")]
	public UIActivityCollectionEventController()
	{
	}

	[Token(Token = "0x6009ACE")]
	[Address(RVA = "0x2A06E80", Offset = "0x2A06E80", VA = "0x2A06E80")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009ACF")]
	[Address(RVA = "0x2A06F24", Offset = "0x2A06F24", VA = "0x2A06F24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009AD0")]
	[Address(RVA = "0x2A0735C", Offset = "0x2A0735C", VA = "0x2A0735C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009AD1")]
	[Address(RVA = "0x2A0742C", Offset = "0x2A0742C", VA = "0x2A0742C", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009AD2")]
	[Address(RVA = "0x2A0754C", Offset = "0x2A0754C", VA = "0x2A0754C")]
	private void UpdateIntroData()
	{
	}

	[Token(Token = "0x6009AD3")]
	[Address(RVA = "0x2A07BA8", Offset = "0x2A07BA8", VA = "0x2A07BA8")]
	private void UpdateActivityInfo()
	{
	}

	[Token(Token = "0x6009AD4")]
	[Address(RVA = "0x2A07F50", Offset = "0x2A07F50", VA = "0x2A07F50")]
	private void OnClickToken0()
	{
	}

	[Token(Token = "0x6009AD5")]
	[Address(RVA = "0x2A081C0", Offset = "0x2A081C0", VA = "0x2A081C0")]
	private void OnClickToken1()
	{
	}

	[Token(Token = "0x6009AD6")]
	[Address(RVA = "0x2A08430", Offset = "0x2A08430", VA = "0x2A08430")]
	private void OnClickCountDown()
	{
	}

	[Token(Token = "0x6009AD7")]
	[Address(RVA = "0x2A08678", Offset = "0x2A08678", VA = "0x2A08678")]
	private void OnClickStore()
	{
	}

	[Token(Token = "0x6009AD8")]
	[Address(RVA = "0x2A08760", Offset = "0x2A08760", VA = "0x2A08760", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009AD9")]
	[Address(RVA = "0x2A0890C", Offset = "0x2A0890C", VA = "0x2A0890C", Slot = "36")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009ADA")]
	[Address(RVA = "0x2A09E78", Offset = "0x2A09E78", VA = "0x2A09E78")]
	private void ScrollToFirstNotClaimedItem()
	{
	}

	[Token(Token = "0x6009ADB")]
	[Address(RVA = "0x2A0A5A8", Offset = "0x2A0A5A8", VA = "0x2A0A5A8")]
	private IEnumerator OnEnableRoutine()
	{
		return null;
	}

	[Token(Token = "0x6009ADC")]
	[Address(RVA = "0x2A0A67C", Offset = "0x2A0A67C", VA = "0x2A0A67C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6009ADD")]
	[Address(RVA = "0x2A0A6EC", Offset = "0x2A0A6EC", VA = "0x2A0A6EC", Slot = "37")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009ADE")]
	[Address(RVA = "0x2A0908C", Offset = "0x2A0908C", VA = "0x2A0908C")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x6009ADF")]
	[Address(RVA = "0x2A0AD4C", Offset = "0x2A0AD4C", VA = "0x2A0AD4C")]
	public void SetAD(string url)
	{
	}

	[Token(Token = "0x6009AE0")]
	[Address(RVA = "0x2A0AEEC", Offset = "0x2A0AEEC", VA = "0x2A0AEEC")]
	private void OnDownloadFinish()
	{
	}

	[Token(Token = "0x6009AE1")]
	[Address(RVA = "0x2A094B8", Offset = "0x2A094B8", VA = "0x2A094B8")]
	private void UpdateInfos()
	{
	}

	[Token(Token = "0x6009AE2")]
	[Address(RVA = "0x2A08AF4", Offset = "0x2A08AF4", VA = "0x2A08AF4")]
	private void CreateEventDescList()
	{
	}

	[Token(Token = "0x6009AE3")]
	[Address(RVA = "0x2A0B0E4", Offset = "0x2A0B0E4", VA = "0x2A0B0E4")]
	private UIActivityExchangeItemController CreateEventDesc(ClientActivityDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6009AE4")]
	[Address(RVA = "0x2A0B23C", Offset = "0x2A0B23C", VA = "0x2A0B23C")]
	private static bool _003CScrollToFirstNotClaimedItem_003Em__0(UIActivityCollectionSigninItemController temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6009AE5")]
	[Address(RVA = "0x2A0B2DC", Offset = "0x2A0B2DC", VA = "0x2A0B2DC")]
	private void _003CUpdateInfos_003Em__1()
	{
	}

	[Token(Token = "0x6009AE6")]
	[Address(RVA = "0x2A0B340", Offset = "0x2A0B340", VA = "0x2A0B340")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009AE7")]
	[Address(RVA = "0x2A0B348", Offset = "0x2A0B348", VA = "0x2A0B348")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009AE8")]
	[Address(RVA = "0x2A0B350", Offset = "0x2A0B350", VA = "0x2A0B350")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009AE9")]
	[Address(RVA = "0x2A0B354", Offset = "0x2A0B354", VA = "0x2A0B354")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
