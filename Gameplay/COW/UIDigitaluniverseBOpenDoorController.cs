using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EE5")]
public class UIDigitaluniverseBOpenDoorController : UIPopupWindowController
{
	[Token(Token = "0x2001EE6")]
	private sealed class _003COpenDoor_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C295")]
		[FieldOffset(Offset = "0x8")]
		internal float time;

		[Token(Token = "0x400C296")]
		[FieldOffset(Offset = "0xC")]
		internal CSGetDigitaluniverseSettingsBRes _003Csetting_003E__0;

		[Token(Token = "0x400C297")]
		[FieldOffset(Offset = "0x10")]
		internal bool _003CmatchSwitch_003E__0;

		[Token(Token = "0x400C298")]
		[FieldOffset(Offset = "0x11")]
		internal bool _003ChasDownLoadSingerB_003E__0;

		[Token(Token = "0x400C299")]
		[FieldOffset(Offset = "0x12")]
		internal bool _003CfirstEnter_003E__0;

		[Token(Token = "0x400C29A")]
		[FieldOffset(Offset = "0x14")]
		internal UIDigitaluniverseBOpenDoorController _0024this;

		[Token(Token = "0x400C29B")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400C29C")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400C29D")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17000F68")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60096D3")]
			[Address(RVA = "0x2EFF64C", Offset = "0x2EFF64C", VA = "0x2EFF64C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F69")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60096D4")]
			[Address(RVA = "0x2EFF654", Offset = "0x2EFF654", VA = "0x2EFF654", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60096D1")]
		[Address(RVA = "0x2EFEDBC", Offset = "0x2EFEDBC", VA = "0x2EFEDBC")]
		public _003COpenDoor_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60096D2")]
		[Address(RVA = "0x2EFEDD4", Offset = "0x2EFEDD4", VA = "0x2EFEDD4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60096D5")]
		[Address(RVA = "0x2EFF65C", Offset = "0x2EFF65C", VA = "0x2EFF65C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60096D6")]
		[Address(RVA = "0x2EFF670", Offset = "0x2EFF670", VA = "0x2EFF670", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C28F")]
	[FieldOffset(Offset = "0x48")]
	private UIDigitaluniverseBOpenDoorView m_View;

	[Token(Token = "0x400C290")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelBigEvent.EBigEventEntranceID m_EntranceID;

	[Token(Token = "0x400C291")]
	[FieldOffset(Offset = "0x50")]
	private bool m_ShowCancelBtn;

	[Token(Token = "0x400C292")]
	[FieldOffset(Offset = "0x54")]
	private EV2NavigationPageType m_Type;

	[Token(Token = "0x400C293")]
	[FieldOffset(Offset = "0x58")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C294")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelOptionalDownload m_ModelOptionDownload;

	[Token(Token = "0x60096C8")]
	[Address(RVA = "0x2EFE5C0", Offset = "0x2EFE5C0", VA = "0x2EFE5C0")]
	public UIDigitaluniverseBOpenDoorController()
	{
	}

	[Token(Token = "0x60096C9")]
	[Address(RVA = "0x2EFE5D0", Offset = "0x2EFE5D0", VA = "0x2EFE5D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60096CA")]
	[Address(RVA = "0x2EFE678", Offset = "0x2EFE678", VA = "0x2EFE678", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60096CB")]
	[Address(RVA = "0x2EFE8D4", Offset = "0x2EFE8D4", VA = "0x2EFE8D4")]
	public void SetData(UIModelBigEvent.EBigEventEntranceID entranceID, EV2NavigationPageType type)
	{
	}

	[Token(Token = "0x60096CC")]
	[Address(RVA = "0x2EFEBC4", Offset = "0x2EFEBC4", VA = "0x2EFEBC4", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x60096CD")]
	[Address(RVA = "0x2EFEC1C", Offset = "0x2EFEC1C", VA = "0x2EFEC1C")]
	private void GotoRoleDoor(object[] data)
	{
	}

	[Token(Token = "0x60096CE")]
	[Address(RVA = "0x2EFEAC8", Offset = "0x2EFEAC8", VA = "0x2EFEAC8")]
	private IEnumerator OpenDoor(float time)
	{
		return null;
	}

	[Token(Token = "0x60096CF")]
	[Address(RVA = "0x2EFEDC4", Offset = "0x2EFEDC4", VA = "0x2EFEDC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60096D0")]
	[Address(RVA = "0x2EFEDCC", Offset = "0x2EFEDCC", VA = "0x2EFEDCC")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}
}
