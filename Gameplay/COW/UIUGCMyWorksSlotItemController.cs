using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BAD")]
public class UIUGCMyWorksSlotItemController : UIEasyListItemController
{
	[Token(Token = "0x2002BAE")]
	private sealed class _003CWaitForShareAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010B23")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCMyWorksSlotItemController _0024this;

		[Token(Token = "0x4010B24")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010B25")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010B26")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012F9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60120F7")]
			[Address(RVA = "0x278B634", Offset = "0x278B634", VA = "0x278B634", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012FA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60120F8")]
			[Address(RVA = "0x278B63C", Offset = "0x278B63C", VA = "0x278B63C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60120F5")]
		[Address(RVA = "0x278B388", Offset = "0x278B388", VA = "0x278B388")]
		public _003CWaitForShareAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60120F6")]
		[Address(RVA = "0x278B518", Offset = "0x278B518", VA = "0x278B518", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60120F9")]
		[Address(RVA = "0x278B644", Offset = "0x278B644", VA = "0x278B644", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60120FA")]
		[Address(RVA = "0x278B658", Offset = "0x278B658", VA = "0x278B658", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010B1F")]
	[FieldOffset(Offset = "0x38")]
	private UIUGCMyWorksSlotItemView m_View;

	[Token(Token = "0x4010B20")]
	[FieldOffset(Offset = "0x3C")]
	private SceneEditSlotInfo m_SlotInfo;

	[Token(Token = "0x4010B21")]
	[FieldOffset(Offset = "0x40")]
	private EWorkshop.SlotType m_SlotType;

	[Token(Token = "0x4010B22")]
	[FieldOffset(Offset = "0x44")]
	private EWorkshop.SlotState m_SlotState;

	[Token(Token = "0x60120E1")]
	[Address(RVA = "0x2788DBC", Offset = "0x2788DBC", VA = "0x2788DBC")]
	public UIUGCMyWorksSlotItemController()
	{
	}

	[Token(Token = "0x60120E2")]
	[Address(RVA = "0x2788DC4", Offset = "0x2788DC4", VA = "0x2788DC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60120E3")]
	[Address(RVA = "0x2788E6C", Offset = "0x2788E6C", VA = "0x2788E6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60120E4")]
	[Address(RVA = "0x2789188", Offset = "0x2789188", VA = "0x2789188", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60120E5")]
	[Address(RVA = "0x2789230", Offset = "0x2789230", VA = "0x2789230", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60120E6")]
	[Address(RVA = "0x27894A0", Offset = "0x27894A0", VA = "0x27894A0", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x60120E7")]
	[Address(RVA = "0x278953C", Offset = "0x278953C", VA = "0x278953C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60120E8")]
	[Address(RVA = "0x2788A60", Offset = "0x2788A60", VA = "0x2788A60")]
	public void PlayUploadAnim()
	{
	}

	[Token(Token = "0x60120E9")]
	[Address(RVA = "0x2787C70", Offset = "0x2787C70", VA = "0x2787C70")]
	public void PlayDownloadAnim()
	{
	}

	[Token(Token = "0x60120EA")]
	[Address(RVA = "0x278B214", Offset = "0x278B214", VA = "0x278B214")]
	public void PlayShareAnim()
	{
	}

	[Token(Token = "0x60120EB")]
	[Address(RVA = "0x278AB70", Offset = "0x278AB70", VA = "0x278AB70")]
	private void ProcessUnlockContent()
	{
	}

	[Token(Token = "0x60120EC")]
	[Address(RVA = "0x278A344", Offset = "0x278A344", VA = "0x278A344")]
	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x60120ED")]
	[Address(RVA = "0x278B2BC", Offset = "0x278B2BC", VA = "0x278B2BC")]
	private IEnumerator WaitForShareAnim()
	{
		return null;
	}

	[Token(Token = "0x60120EE")]
	[Address(RVA = "0x278B390", Offset = "0x278B390", VA = "0x278B390")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x60120EF")]
	[Address(RVA = "0x278B3D4", Offset = "0x278B3D4", VA = "0x278B3D4")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x60120F0")]
	[Address(RVA = "0x278B418", Offset = "0x278B418", VA = "0x278B418")]
	private void _003CRefreshCDNMapIcon_003Em__2()
	{
	}

	[Token(Token = "0x60120F1")]
	[Address(RVA = "0x278B4F8", Offset = "0x278B4F8", VA = "0x278B4F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60120F2")]
	[Address(RVA = "0x278B500", Offset = "0x278B500", VA = "0x278B500")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60120F3")]
	[Address(RVA = "0x278B508", Offset = "0x278B508", VA = "0x278B508")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60120F4")]
	[Address(RVA = "0x278B510", Offset = "0x278B510", VA = "0x278B510")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
