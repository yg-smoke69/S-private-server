using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028ED")]
internal class UILauncherPopupMessageController : UIBaseController
{
	[Token(Token = "0x20028EE")]
	public enum EButtonStyle
	{
		[Token(Token = "0x400FBBC")]
		None,
		[Token(Token = "0x400FBBD")]
		OK,
		[Token(Token = "0x400FBBE")]
		Update
	}

	[Token(Token = "0x20028EF")]
	public enum ELauncherMessageType
	{
		[Token(Token = "0x400FBC0")]
		SystemError,
		[Token(Token = "0x400FBC1")]
		Maintenance,
		[Token(Token = "0x400FBC2")]
		HotUpdate,
		[Token(Token = "0x400FBC3")]
		VersionUpdate,
		[Token(Token = "0x400FBC4")]
		DownloadRetry
	}

	[Token(Token = "0x20028F0")]
	private sealed class _003CAutoScrollItem_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FBC5")]
		[FieldOffset(Offset = "0x8")]
		internal UILauncherPopupMessageController _0024this;

		[Token(Token = "0x400FBC6")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400FBC7")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400FBC8")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700120D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60102D9")]
			[Address(RVA = "0x1A87B50", Offset = "0x1A87B50", VA = "0x1A87B50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700120E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60102DA")]
			[Address(RVA = "0x1A87B58", Offset = "0x1A87B58", VA = "0x1A87B58", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60102D7")]
		[Address(RVA = "0x1A87360", Offset = "0x1A87360", VA = "0x1A87360")]
		public _003CAutoScrollItem_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60102D8")]
		[Address(RVA = "0x1A87A30", Offset = "0x1A87A30", VA = "0x1A87A30", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60102DB")]
		[Address(RVA = "0x1A87B60", Offset = "0x1A87B60", VA = "0x1A87B60", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60102DC")]
		[Address(RVA = "0x1A87B74", Offset = "0x1A87B74", VA = "0x1A87B74", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FBA9")]
	[FieldOffset(Offset = "0x28")]
	private UILauncherPopupMessageView m_View;

	[Token(Token = "0x400FBAA")]
	[FieldOffset(Offset = "0x2C")]
	private EButtonStyle m_ButtonStyle;

	[Token(Token = "0x400FBAB")]
	[FieldOffset(Offset = "0x30")]
	private ELauncherMessageType m_MessageType;

	[Token(Token = "0x400FBAC")]
	[FieldOffset(Offset = "0x34")]
	private string m_Info;

	[Token(Token = "0x400FBAD")]
	[FieldOffset(Offset = "0x38")]
	private string[] m_CDNUrlList;

	[Token(Token = "0x400FBAE")]
	[FieldOffset(Offset = "0x3C")]
	private string m_PatchNoteUrl;

	[Token(Token = "0x400FBAF")]
	[FieldOffset(Offset = "0x40")]
	private string m_WebViewUrl;

	[Token(Token = "0x400FBB0")]
	[FieldOffset(Offset = "0x44")]
	private WebView m_WebView;

	[Token(Token = "0x400FBB1")]
	[FieldOffset(Offset = "0x48")]
	private string m_BGUrl;

	[Token(Token = "0x400FBB2")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_HasMaxHint;

	[Token(Token = "0x400FBB3")]
	[FieldOffset(Offset = "0x50")]
	private Action m_OnOK;

	[Token(Token = "0x400FBB4")]
	[FieldOffset(Offset = "0x54")]
	private Action m_OnRetry;

	[Token(Token = "0x400FBB5")]
	[FieldOffset(Offset = "0x58")]
	private int m_selectedIndex;

	[Token(Token = "0x400FBB6")]
	[FieldOffset(Offset = "0x5C")]
	private List<UILobbyDotController> m_DotCtrls;

	[Token(Token = "0x400FBB7")]
	[FieldOffset(Offset = "0x60")]
	private List<UINetworkTexture> m_NetworkTextures;

	[Token(Token = "0x400FBB8")]
	[FieldOffset(Offset = "0x64")]
	private UICenterOnChild m_centerOnChild;

	[Token(Token = "0x400FBB9")]
	[FieldOffset(Offset = "0x0")]
	private static string defaultCDN;

	[Token(Token = "0x400FBBA")]
	[FieldOffset(Offset = "0x4")]
	private static string defaultBGCDN;

	[Token(Token = "0x60102C0")]
	[Address(RVA = "0x1A8493C", Offset = "0x1A8493C", VA = "0x1A8493C")]
	public UILauncherPopupMessageController()
	{
	}

	[Token(Token = "0x60102C1")]
	[Address(RVA = "0x1A84A30", Offset = "0x1A84A30", VA = "0x1A84A30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60102C2")]
	[Address(RVA = "0x1A84B00", Offset = "0x1A84B00", VA = "0x1A84B00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60102C3")]
	[Address(RVA = "0x1A8502C", Offset = "0x1A8502C", VA = "0x1A8502C", Slot = "29")]
	public override void OnShare(bool success, int platform)
	{
	}

	[Token(Token = "0x60102C4")]
	[Address(RVA = "0x1A850E0", Offset = "0x1A850E0", VA = "0x1A850E0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60102C5")]
	[Address(RVA = "0x1A85150", Offset = "0x1A85150", VA = "0x1A85150", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60102C6")]
	[Address(RVA = "0x1A851E0", Offset = "0x1A851E0", VA = "0x1A851E0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60102C7")]
	[Address(RVA = "0x1A85298", Offset = "0x1A85298", VA = "0x1A85298")]
	public void ShowMessageBox(string info, ELauncherMessageType mbType, [Optional] Action onOK, EButtonStyle buttonStyle = EButtonStyle.OK, [Optional] string[] urlList, [Optional] string patchNoteUrl, [Optional] Action onRetry, [Optional] string webViewUrl, [Optional] string bgUrl, [Optional] string maxUrl)
	{
	}

	[Token(Token = "0x60102C8")]
	[Address(RVA = "0x1A86DA0", Offset = "0x1A86DA0", VA = "0x1A86DA0")]
	private void OnPatchNoteBtnClick()
	{
	}

	[Token(Token = "0x60102C9")]
	[Address(RVA = "0x1A86ECC", Offset = "0x1A86ECC", VA = "0x1A86ECC")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x60102CA")]
	[Address(RVA = "0x1A85478", Offset = "0x1A85478", VA = "0x1A85478")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x60102CB")]
	[Address(RVA = "0x1A87294", Offset = "0x1A87294", VA = "0x1A87294")]
	private IEnumerator AutoScrollItem()
	{
		return null;
	}

	[Token(Token = "0x60102CC")]
	[Address(RVA = "0x1A87368", Offset = "0x1A87368", VA = "0x1A87368")]
	private void OnAutoScrollAdItem()
	{
	}

	[Token(Token = "0x60102CD")]
	[Address(RVA = "0x1A8753C", Offset = "0x1A8753C", VA = "0x1A8753C", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x60102CE")]
	[Address(RVA = "0x1A86F7C", Offset = "0x1A86F7C", VA = "0x1A86F7C")]
	private UILobbyDotController CreateDot()
	{
		return null;
	}

	[Token(Token = "0x60102CF")]
	[Address(RVA = "0x1A87700", Offset = "0x1A87700", VA = "0x1A87700")]
	private void GetCenterItem(GameObject centeredObject)
	{
	}

	[Token(Token = "0x60102D1")]
	[Address(RVA = "0x1A87A00", Offset = "0x1A87A00", VA = "0x1A87A00")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60102D2")]
	[Address(RVA = "0x1A87A08", Offset = "0x1A87A08", VA = "0x1A87A08")]
	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	[Token(Token = "0x60102D3")]
	[Address(RVA = "0x1A87A10", Offset = "0x1A87A10", VA = "0x1A87A10")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60102D4")]
	[Address(RVA = "0x1A87A18", Offset = "0x1A87A18", VA = "0x1A87A18")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60102D5")]
	[Address(RVA = "0x1A87A20", Offset = "0x1A87A20", VA = "0x1A87A20")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60102D6")]
	[Address(RVA = "0x1A87A28", Offset = "0x1A87A28", VA = "0x1A87A28")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
