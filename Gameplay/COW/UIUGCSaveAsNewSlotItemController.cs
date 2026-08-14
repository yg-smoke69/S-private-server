using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BBF")]
internal class UIUGCSaveAsNewSlotItemController : UIBaseController
{
	[Token(Token = "0x2002BC0")]
	public enum ESaveAsType
	{
		[Token(Token = "0x4010B6F")]
		ESaveAsType_Lobby,
		[Token(Token = "0x4010B70")]
		ESaveAsType_InGame
	}

	[Token(Token = "0x2002BC1")]
	private sealed class _003COnBtnClick_003Ec__AnonStorey1
	{
		[Token(Token = "0x2002BC2")]
		private sealed class _003COnBtnClick_003Ec__AnonStorey0
		{
			[Token(Token = "0x4010B73")]
			[FieldOffset(Offset = "0x8")]
			internal bool b;

			[Token(Token = "0x4010B74")]
			[FieldOffset(Offset = "0xC")]
			internal _003COnBtnClick_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

			[Token(Token = "0x6012182")]
			[Address(RVA = "0xF3C118", Offset = "0xF3C118", VA = "0xF3C118")]
			public _003COnBtnClick_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6012183")]
			[Address(RVA = "0xF3D1E8", Offset = "0xF3D1E8", VA = "0xF3D1E8")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x4010B71")]
		[FieldOffset(Offset = "0x8")]
		internal bool needPop;

		[Token(Token = "0x4010B72")]
		[FieldOffset(Offset = "0xC")]
		internal UIUGCSaveAsNewSlotItemController _0024this;

		[Token(Token = "0x601217D")]
		[Address(RVA = "0xF3B288", Offset = "0xF3B288", VA = "0xF3B288")]
		public _003COnBtnClick_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601217E")]
		[Address(RVA = "0xF3BAC8", Offset = "0xF3BAC8", VA = "0xF3BAC8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x601217F")]
		[Address(RVA = "0xF3BFF8", Offset = "0xF3BFF8", VA = "0xF3BFF8")]
		internal void _003C_003Em__1(bool b)
		{
		}

		[Token(Token = "0x6012180")]
		[Address(RVA = "0xF3C120", Offset = "0xF3C120", VA = "0xF3C120")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x6012181")]
		[Address(RVA = "0xF3C864", Offset = "0xF3C864", VA = "0xF3C864")]
		internal void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x4010B68")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCSaveAsNewSlotItemView m_View;

	[Token(Token = "0x4010B69")]
	[FieldOffset(Offset = "0x2C")]
	private SceneEditSlotInfo m_DestSlotInfo;

	[Token(Token = "0x4010B6A")]
	[FieldOffset(Offset = "0x30")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x4010B6B")]
	[FieldOffset(Offset = "0x34")]
	private SceneEditSlotInfo m_SrcSlotInfo;

	[Token(Token = "0x4010B6C")]
	[FieldOffset(Offset = "0x38")]
	private ESaveAsType m_CurSaveAsType;

	[Token(Token = "0x4010B6D")]
	[FieldOffset(Offset = "0x3C")]
	private Action m_CallBack;

	[Token(Token = "0x6012172")]
	[Address(RVA = "0xF37FF8", Offset = "0xF37FF8", VA = "0xF37FF8")]
	public UIUGCSaveAsNewSlotItemController()
	{
	}

	[Token(Token = "0x6012173")]
	[Address(RVA = "0xF3807C", Offset = "0xF3807C", VA = "0xF3807C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012174")]
	[Address(RVA = "0xF38124", Offset = "0xF38124", VA = "0xF38124", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012175")]
	[Address(RVA = "0xF382F0", Offset = "0xF382F0", VA = "0xF382F0")]
	public void SetUIData(SceneEditSlotInfo selectedInfo, SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x6012176")]
	[Address(RVA = "0xF39A44", Offset = "0xF39A44", VA = "0xF39A44")]
	public void SetCallBack(Action callback)
	{
	}

	[Token(Token = "0x6012177")]
	[Address(RVA = "0xF38CC4", Offset = "0xF38CC4", VA = "0xF38CC4")]
	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x6012178")]
	[Address(RVA = "0xF393A4", Offset = "0xF393A4", VA = "0xF393A4")]
	private void ProcessUnlockContent()
	{
	}

	[Token(Token = "0x6012179")]
	[Address(RVA = "0xF3ABB4", Offset = "0xF3ABB4", VA = "0xF3ABB4")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x601217A")]
	[Address(RVA = "0xF3B290", Offset = "0xF3B290", VA = "0xF3B290")]
	private void ShowLobbySaveAsPop(Action callBack)
	{
	}

	[Token(Token = "0x601217B")]
	[Address(RVA = "0xF3B5C4", Offset = "0xF3B5C4", VA = "0xF3B5C4")]
	private void _003CRefreshCDNMapIcon_003Em__0()
	{
	}

	[Token(Token = "0x601217C")]
	[Address(RVA = "0xF3BAC0", Offset = "0xF3BAC0", VA = "0xF3BAC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
