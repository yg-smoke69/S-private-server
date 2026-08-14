using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003AE2")]
internal class UILauncherController : UIBaseController
{
	[Token(Token = "0x2003AE3")]
	public delegate UIBaseController CreateMessageBox(string path, Type classType);

	[Token(Token = "0x2003AE4")]
	private enum EHttpVerInfoErrorCode
	{
		[Token(Token = "0x401914F")]
		OK,
		[Token(Token = "0x4019150")]
		ERROR,
		[Token(Token = "0x4019151")]
		NOVERSIONFOUND
	}

	[Token(Token = "0x2003AE5")]
	private class HttpVerInfo
	{
		[Token(Token = "0x4019152")]
		[FieldOffset(Offset = "0x8")]
		public uint code;

		[Token(Token = "0x4019153")]
		[FieldOffset(Offset = "0xC")]
		public bool is_server_open;

		[Token(Token = "0x4019154")]
		[FieldOffset(Offset = "0xD")]
		public bool is_firewall_open;

		[Token(Token = "0x4019155")]
		[FieldOffset(Offset = "0xE")]
		public bool need_track_hotupdate;

		[Token(Token = "0x4019156")]
		[FieldOffset(Offset = "0x10")]
		public double min_hint_size;

		[Token(Token = "0x4019157")]
		[FieldOffset(Offset = "0x18")]
		public string billboard_cdn_url;

		[Token(Token = "0x4019158")]
		[FieldOffset(Offset = "0x1C")]
		public string billboard_msg;

		[Token(Token = "0x4019159")]
		[FieldOffset(Offset = "0x20")]
		public string patchnote_url;

		[Token(Token = "0x401915A")]
		[FieldOffset(Offset = "0x24")]
		public string web_url;

		[Token(Token = "0x401915B")]
		[FieldOffset(Offset = "0x28")]
		public string billboard_bg_url;

		[Token(Token = "0x401915C")]
		[FieldOffset(Offset = "0x2C")]
		public string max_store;

		[Token(Token = "0x401915D")]
		[FieldOffset(Offset = "0x30")]
		public string max_web;

		[Token(Token = "0x401915E")]
		[FieldOffset(Offset = "0x34")]
		public string max_video;

		[Token(Token = "0x401915F")]
		[FieldOffset(Offset = "0x38")]
		public string remote_version;

		[Token(Token = "0x4019160")]
		[FieldOffset(Offset = "0x3C")]
		public string remote_option_version;

		[Token(Token = "0x4019161")]
		[FieldOffset(Offset = "0x40")]
		public string cdn_url;

		[Token(Token = "0x4019162")]
		[FieldOffset(Offset = "0x44")]
		public string backup_cdn_url;

		[Token(Token = "0x4019163")]
		[FieldOffset(Offset = "0x48")]
		public string server_url;

		[Token(Token = "0x4019164")]
		[FieldOffset(Offset = "0x4C")]
		public bool is_review_server;

		[Token(Token = "0x4019165")]
		[FieldOffset(Offset = "0x50")]
		public string appstore_url;

		[Token(Token = "0x4019166")]
		[FieldOffset(Offset = "0x54")]
		public bool force_to_restart_app;

		[Token(Token = "0x4019167")]
		[FieldOffset(Offset = "0x58")]
		public string country_code;

		[Token(Token = "0x4019168")]
		[FieldOffset(Offset = "0x5C")]
		public int gdpr_version;

		[Token(Token = "0x4019169")]
		[FieldOffset(Offset = "0x60")]
		public string client_ip;

		[Token(Token = "0x401916A")]
		[FieldOffset(Offset = "0x64")]
		public string maintenance_announcement;

		[Token(Token = "0x401916B")]
		[FieldOffset(Offset = "0x68")]
		public string maintenance_region;

		[Token(Token = "0x401916C")]
		[FieldOffset(Offset = "0x6C")]
		public string[] need_check_ip_list;

		[Token(Token = "0x401916D")]
		[FieldOffset(Offset = "0x70")]
		public string network_log_server;

		[Token(Token = "0x401916E")]
		[FieldOffset(Offset = "0x74")]
		public string web_log_server;

		[Token(Token = "0x401916F")]
		[FieldOffset(Offset = "0x78")]
		public int login_failed_count;

		[Token(Token = "0x4019170")]
		[FieldOffset(Offset = "0x7C")]
		public string test_url;

		[Token(Token = "0x4019171")]
		[FieldOffset(Offset = "0x80")]
		public string img_cdn_url;

		[Token(Token = "0x4019172")]
		[FieldOffset(Offset = "0x84")]
		public string core_url;

		[Token(Token = "0x4019173")]
		[FieldOffset(Offset = "0x88")]
		public string[] core_ip_list;

		[Token(Token = "0x4019174")]
		[FieldOffset(Offset = "0x8C")]
		public bool is_update_btn_show;

		[Token(Token = "0x4019175")]
		[FieldOffset(Offset = "0x8D")]
		public bool is_use_multi_download;

		[Token(Token = "0x4019176")]
		[FieldOffset(Offset = "0x8E")]
		public bool use_login_optional_download;

		[Token(Token = "0x4019177")]
		[FieldOffset(Offset = "0x8F")]
		public bool use_background_download;

		[Token(Token = "0x4019178")]
		[FieldOffset(Offset = "0x90")]
		public bool use_background_download_lobby;

		[Token(Token = "0x4019179")]
		[FieldOffset(Offset = "0x94")]
		public float use_backgound_download_mem_thredshold;

		[Token(Token = "0x401917A")]
		[FieldOffset(Offset = "0x98")]
		public bool sigma_login;

		[Token(Token = "0x401917B")]
		[FieldOffset(Offset = "0x99")]
		public bool sigma_switch;

		[Token(Token = "0x401917C")]
		[FieldOffset(Offset = "0x9A")]
		public bool enable_clear_mem_when_autopause;

		[Token(Token = "0x401917D")]
		[FieldOffset(Offset = "0xA0")]
		public double space_required_in_GB;

		[Token(Token = "0x401917E")]
		[FieldOffset(Offset = "0xA8")]
		public string sigma_backup_url;

		[Token(Token = "0x401917F")]
		[FieldOffset(Offset = "0xAC")]
		public string login_download_optionalpack;

		[Token(Token = "0x601761F")]
		[Address(RVA = "0x1A83660", Offset = "0x1A83660", VA = "0x1A83660")]
		public HttpVerInfo()
		{
		}
	}

	[Token(Token = "0x2003AE6")]
	private sealed class _003COnColdUpdate_003Ec__AnonStorey6
	{
		[Token(Token = "0x4019180")]
		[FieldOffset(Offset = "0x8")]
		internal float spaceRequiredInGB;

		[Token(Token = "0x4019181")]
		[FieldOffset(Offset = "0xC")]
		internal UILauncherController _0024this;

		[Token(Token = "0x6017620")]
		[Address(RVA = "0x1A82270", Offset = "0x1A82270", VA = "0x1A82270")]
		public _003COnColdUpdate_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6017621")]
		[Address(RVA = "0x1A82278", Offset = "0x1A82278", VA = "0x1A82278")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003AE7")]
	private sealed class _003CStartLaunchGame_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019182")]
		[FieldOffset(Offset = "0x8")]
		internal Action _003Ccaller_003E__0;

		[Token(Token = "0x4019183")]
		[FieldOffset(Offset = "0xC")]
		internal UILauncherController _0024this;

		[Token(Token = "0x4019184")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4019185")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x4019186")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170017B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6017624")]
			[Address(RVA = "0x1A82BFC", Offset = "0x1A82BFC", VA = "0x1A82BFC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6017625")]
			[Address(RVA = "0x1A82C04", Offset = "0x1A82C04", VA = "0x1A82C04", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017622")]
		[Address(RVA = "0x1A82948", Offset = "0x1A82948", VA = "0x1A82948")]
		public _003CStartLaunchGame_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6017623")]
		[Address(RVA = "0x1A82950", Offset = "0x1A82950", VA = "0x1A82950", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6017626")]
		[Address(RVA = "0x1A82C0C", Offset = "0x1A82C0C", VA = "0x1A82C0C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6017627")]
		[Address(RVA = "0x1A82C20", Offset = "0x1A82C20", VA = "0x1A82C20", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003AE8")]
	private sealed class _003CStartHotUpdating_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019187")]
		[FieldOffset(Offset = "0x8")]
		internal UILauncherController _0024this;

		[Token(Token = "0x4019188")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4019189")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x401918A")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170017BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601762A")]
			[Address(RVA = "0x1A8289C", Offset = "0x1A8289C", VA = "0x1A8289C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601762B")]
			[Address(RVA = "0x1A828A4", Offset = "0x1A828A4", VA = "0x1A828A4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017628")]
		[Address(RVA = "0x1A82700", Offset = "0x1A82700", VA = "0x1A82700")]
		public _003CStartHotUpdating_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6017629")]
		[Address(RVA = "0x1A82708", Offset = "0x1A82708", VA = "0x1A82708", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601762C")]
		[Address(RVA = "0x1A828AC", Offset = "0x1A828AC", VA = "0x1A828AC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601762D")]
		[Address(RVA = "0x1A828C0", Offset = "0x1A828C0", VA = "0x1A828C0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003AE9")]
	private sealed class _003CStartCheckVersion_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401918B")]
		[FieldOffset(Offset = "0x8")]
		internal UILauncherController _0024this;

		[Token(Token = "0x401918C")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x401918D")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x401918E")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170017BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6017630")]
			[Address(RVA = "0x1A82654", Offset = "0x1A82654", VA = "0x1A82654", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6017631")]
			[Address(RVA = "0x1A8265C", Offset = "0x1A8265C", VA = "0x1A8265C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601762E")]
		[Address(RVA = "0x1A82560", Offset = "0x1A82560", VA = "0x1A82560")]
		public _003CStartCheckVersion_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x601762F")]
		[Address(RVA = "0x1A82568", Offset = "0x1A82568", VA = "0x1A82568", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6017632")]
		[Address(RVA = "0x1A82664", Offset = "0x1A82664", VA = "0x1A82664", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6017633")]
		[Address(RVA = "0x1A82678", Offset = "0x1A82678", VA = "0x1A82678", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003AEA")]
	private sealed class _003CStartLocDownload_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401918F")]
		[FieldOffset(Offset = "0x8")]
		internal UILauncherController _0024this;

		[Token(Token = "0x4019190")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4019191")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4019192")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170017BF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6017636")]
			[Address(RVA = "0x1A82E70", Offset = "0x1A82E70", VA = "0x1A82E70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017C0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6017637")]
			[Address(RVA = "0x1A82E78", Offset = "0x1A82E78", VA = "0x1A82E78", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6017634")]
		[Address(RVA = "0x1A82CA8", Offset = "0x1A82CA8", VA = "0x1A82CA8")]
		public _003CStartLocDownload_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x6017635")]
		[Address(RVA = "0x1A82CB0", Offset = "0x1A82CB0", VA = "0x1A82CB0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6017638")]
		[Address(RVA = "0x1A82E80", Offset = "0x1A82E80", VA = "0x1A82E80", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6017639")]
		[Address(RVA = "0x1A82E94", Offset = "0x1A82E94", VA = "0x1A82E94", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003AEB")]
	private sealed class _003CStartLoginCommonDownload_003Ec__Iterator4 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019193")]
		[FieldOffset(Offset = "0x8")]
		internal UILauncherController _0024this;

		[Token(Token = "0x4019194")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4019195")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4019196")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170017C1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601763C")]
			[Address(RVA = "0x1A830C4", Offset = "0x1A830C4", VA = "0x1A830C4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017C2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601763D")]
			[Address(RVA = "0x1A830CC", Offset = "0x1A830CC", VA = "0x1A830CC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601763A")]
		[Address(RVA = "0x1A82F1C", Offset = "0x1A82F1C", VA = "0x1A82F1C")]
		public _003CStartLoginCommonDownload_003Ec__Iterator4()
		{
		}

		[Token(Token = "0x601763B")]
		[Address(RVA = "0x1A82F24", Offset = "0x1A82F24", VA = "0x1A82F24", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601763E")]
		[Address(RVA = "0x1A830D4", Offset = "0x1A830D4", VA = "0x1A830D4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601763F")]
		[Address(RVA = "0x1A830E8", Offset = "0x1A830E8", VA = "0x1A830E8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003AEC")]
	private sealed class _003CStartLoginDownload_003Ec__AnonStorey8
	{
		[Token(Token = "0x4019197")]
		[FieldOffset(Offset = "0x8")]
		internal Action<ResErrorCode> finished_callback;

		[Token(Token = "0x4019198")]
		[FieldOffset(Offset = "0xC")]
		internal List<uint> type_List;

		[Token(Token = "0x4019199")]
		[FieldOffset(Offset = "0x10")]
		internal UILauncherController _0024this;

		[Token(Token = "0x6017640")]
		[Address(RVA = "0x1A83170", Offset = "0x1A83170", VA = "0x1A83170")]
		public _003CStartLoginDownload_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6017641")]
		[Address(RVA = "0x1A83178", Offset = "0x1A83178", VA = "0x1A83178")]
		internal void _003C_003Em__0(ResErrorCode _error_code, ResDownloadType _context_type)
		{
		}
	}

	[Token(Token = "0x2003AED")]
	private sealed class _003CCheckVersion_003Ec__AnonStorey5
	{
		[Token(Token = "0x401919A")]
		[FieldOffset(Offset = "0x8")]
		internal float toMB;

		[Token(Token = "0x401919B")]
		[FieldOffset(Offset = "0xC")]
		internal UILauncherController _0024this;

		[Token(Token = "0x6017642")]
		[Address(RVA = "0x1A821EC", Offset = "0x1A821EC", VA = "0x1A821EC")]
		public _003CCheckVersion_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6017643")]
		[Address(RVA = "0x1A821F4", Offset = "0x1A821F4", VA = "0x1A821F4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003AEE")]
	private sealed class _003COnHotUpdateFinished_003Ec__AnonStorey7
	{
		[Token(Token = "0x401919C")]
		[FieldOffset(Offset = "0x8")]
		internal float toMB;

		[Token(Token = "0x401919D")]
		[FieldOffset(Offset = "0xC")]
		internal UILauncherController _0024this;

		[Token(Token = "0x6017644")]
		[Address(RVA = "0x1A824DC", Offset = "0x1A824DC", VA = "0x1A824DC")]
		public _003COnHotUpdateFinished_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6017645")]
		[Address(RVA = "0x1A824E4", Offset = "0x1A824E4", VA = "0x1A824E4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401912D")]
	[FieldOffset(Offset = "0x28")]
	public Action OnLaunchGame;

	[Token(Token = "0x401912E")]
	[FieldOffset(Offset = "0x2C")]
	public CreateMessageBox OnCreateMessageBox;

	[Token(Token = "0x401912F")]
	[FieldOffset(Offset = "0x30")]
	public bool IsRestart;

	[Token(Token = "0x4019130")]
	private const uint UI_GROUP_HOTUPDATE = 2u;

	[Token(Token = "0x4019131")]
	private const uint UI_GROUP_MAX = 4u;

	[Token(Token = "0x4019132")]
	private const uint UI_GROUP_QUIT = 8u;

	[Token(Token = "0x4019133")]
	[FieldOffset(Offset = "0x34")]
	private UILauncherPopupMessageController m_MessageBox;

	[Token(Token = "0x4019134")]
	[FieldOffset(Offset = "0x38")]
	private UILauncherMaxController m_FFMaxMessageBox;

	[Token(Token = "0x4019135")]
	[FieldOffset(Offset = "0x3C")]
	private UIPopupMessageBoxController m_QuitMessageBox;

	[Token(Token = "0x4019136")]
	[FieldOffset(Offset = "0x40")]
	private UILauncherConfirmWnd m_ConfirmWnd;

	[Token(Token = "0x4019137")]
	[FieldOffset(Offset = "0x44")]
	private UILauncherView m_View;

	[Token(Token = "0x4019138")]
	[FieldOffset(Offset = "0x48")]
	private float m_Progress;

	[Token(Token = "0x4019139")]
	[FieldOffset(Offset = "0x4C")]
	private float m_TotalHotUpdatingMBytes;

	[Token(Token = "0x401913A")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsHotUpdating;

	[Token(Token = "0x401913B")]
	[FieldOffset(Offset = "0x51")]
	private bool m_IsUnzipping;

	[Token(Token = "0x401913C")]
	[FieldOffset(Offset = "0x54")]
	private int m_LastSleepTimeout;

	[Token(Token = "0x401913D")]
	[FieldOffset(Offset = "0x58")]
	private bool m_LastRunInBackground;

	[Token(Token = "0x401913E")]
	[FieldOffset(Offset = "0x59")]
	private bool m_Cleanup;

	[Token(Token = "0x401913F")]
	[FieldOffset(Offset = "0x5C")]
	private HttpVerInfo remoteVerInfo;

	[Token(Token = "0x4019140")]
	[FieldOffset(Offset = "0x60")]
	private bool m_NeedTrackHotUpdate;

	[Token(Token = "0x4019141")]
	[FieldOffset(Offset = "0x64")]
	private float m_ShowMessageSize;

	[Token(Token = "0x4019142")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsDownloadingLoc;

	[Token(Token = "0x4019143")]
	[FieldOffset(Offset = "0x69")]
	private bool m_IsLoadingGame;

	[Token(Token = "0x4019144")]
	[FieldOffset(Offset = "0x6A")]
	private bool m_IsDownloadingClothesCommon;

	[Token(Token = "0x4019145")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_NowDownloadingType;

	[Token(Token = "0x4019146")]
	[FieldOffset(Offset = "0x70")]
	private int m_LocErrorCount;

	[Token(Token = "0x4019147")]
	[FieldOffset(Offset = "0x74")]
	private bool m_NeedUseBackUpCDN;

	[Token(Token = "0x4019148")]
	[FieldOffset(Offset = "0x78")]
	private int m_RemoteFileInfoErrCount;

	[Token(Token = "0x4019149")]
	[FieldOffset(Offset = "0x7C")]
	private List<uint> m_LoginDownloadResList;

	[Token(Token = "0x401914A")]
	[FieldOffset(Offset = "0x80")]
	private bool m_CanInGameHotupdate;

	[Token(Token = "0x401914B")]
	[FieldOffset(Offset = "0x84")]
	private uint m_PrevActiveGroup;

	[Token(Token = "0x401914C")]
	[FieldOffset(Offset = "0x88")]
	private uint m_LastActiveGroup;

	[Token(Token = "0x401914D")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60175EC")]
	[Address(RVA = "0x22DB4C4", Offset = "0x22DB4C4", VA = "0x22DB4C4")]
	public UILauncherController()
	{
	}

	[Token(Token = "0x60175ED")]
	[Address(RVA = "0x22DB5BC", Offset = "0x22DB5BC", VA = "0x22DB5BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60175EE")]
	[Address(RVA = "0x22DB744", Offset = "0x22DB744", VA = "0x22DB744", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60175EF")]
	[Address(RVA = "0x22DC318", Offset = "0x22DC318", VA = "0x22DC318")]
	private void AppFlyerTrackStart()
	{
	}

	[Token(Token = "0x60175F0")]
	[Address(RVA = "0x22DC4C8", Offset = "0x22DC4C8", VA = "0x22DC4C8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60175F1")]
	[Address(RVA = "0x22DC900", Offset = "0x22DC900", VA = "0x22DC900")]
	private void Update()
	{
	}

	[Token(Token = "0x60175F2")]
	[Address(RVA = "0x22DDA4C", Offset = "0x22DDA4C", VA = "0x22DDA4C")]
	private void RetrieveVerInfo()
	{
	}

	[Token(Token = "0x60175F3")]
	[Address(RVA = "0x22DE3AC", Offset = "0x22DE3AC", VA = "0x22DE3AC")]
	private void OpenFFMaxIntro()
	{
	}

	[Token(Token = "0x60175F4")]
	[Address(RVA = "0x22DE6A0", Offset = "0x22DE6A0", VA = "0x22DE6A0")]
	private void OpenSpaceInsufficientNoticeWnd(float spaceRequiredInGB, float freeSpaceInGB)
	{
	}

	[Token(Token = "0x60175F5")]
	[Address(RVA = "0x22DBE4C", Offset = "0x22DBE4C", VA = "0x22DBE4C")]
	private void CheckVersion()
	{
	}

	[Token(Token = "0x60175F6")]
	[Address(RVA = "0x22DED60", Offset = "0x22DED60", VA = "0x22DED60")]
	private void OnColdUpdate(float spaceRequiredInGB = 0f)
	{
	}

	[Token(Token = "0x60175F7")]
	[Address(RVA = "0x22DEB38", Offset = "0x22DEB38", VA = "0x22DEB38")]
	private string GetSpaceByRule(float GB)
	{
		return null;
	}

	[Token(Token = "0x60175F8")]
	[Address(RVA = "0x22DF200", Offset = "0x22DF200", VA = "0x22DF200")]
	private void OnHotUpdateError()
	{
	}

	[Token(Token = "0x60175F9")]
	[Address(RVA = "0x22DF55C", Offset = "0x22DF55C", VA = "0x22DF55C")]
	private void OnLocUpdateError(ResErrorCode last_err)
	{
	}

	[Token(Token = "0x60175FA")]
	[Address(RVA = "0x22DF9E0", Offset = "0x22DF9E0", VA = "0x22DF9E0")]
	private void OnHotUpdateFinished(ResErrorCode result)
	{
	}

	[Token(Token = "0x60175FB")]
	[Address(RVA = "0x22DFA50", Offset = "0x22DFA50", VA = "0x22DFA50")]
	private void OnHotUpdateFinished(ResErrorCode result, bool is_from_pass)
	{
	}

	[Token(Token = "0x60175FC")]
	[Address(RVA = "0x22DFD08", Offset = "0x22DFD08", VA = "0x22DFD08")]
	private IEnumerator StartLaunchGame()
	{
		return null;
	}

	[Token(Token = "0x60175FD")]
	[Address(RVA = "0x22DFDD4", Offset = "0x22DFDD4", VA = "0x22DFDD4")]
	private IEnumerator StartHotUpdating()
	{
		return null;
	}

	[Token(Token = "0x60175FE")]
	[Address(RVA = "0x22DFEA0", Offset = "0x22DFEA0", VA = "0x22DFEA0")]
	private IEnumerator StartCheckVersion()
	{
		return null;
	}

	[Token(Token = "0x60175FF")]
	[Address(RVA = "0x22DFF6C", Offset = "0x22DFF6C", VA = "0x22DFF6C")]
	private IEnumerator StartLocDownload()
	{
		return null;
	}

	[Token(Token = "0x6017600")]
	[Address(RVA = "0x22E0038", Offset = "0x22E0038", VA = "0x22E0038")]
	private IEnumerator StartLoginCommonDownload()
	{
		return null;
	}

	[Token(Token = "0x6017601")]
	[Address(RVA = "0x22E0104", Offset = "0x22E0104", VA = "0x22E0104")]
	public void StartLoginDownload(List<uint> type_List, [Optional] Action<ResErrorCode> finished_callback)
	{
	}

	[Token(Token = "0x6017602")]
	[Address(RVA = "0x22DECF0", Offset = "0x22DECF0", VA = "0x22DECF0")]
	private void OnStartUpdating()
	{
	}

	[Token(Token = "0x6017603")]
	[Address(RVA = "0x22DF190", Offset = "0x22DF190", VA = "0x22DF190")]
	private void OnFinishUpdating()
	{
	}

	[Token(Token = "0x6017604")]
	[Address(RVA = "0x22DBCA8", Offset = "0x22DBCA8", VA = "0x22DBCA8")]
	private void SetActiveGroup(uint activeGroup)
	{
	}

	[Token(Token = "0x6017605")]
	[Address(RVA = "0x22E04B4", Offset = "0x22E04B4", VA = "0x22E04B4")]
	private void SetPreviousActiveGroup()
	{
	}

	[Token(Token = "0x6017606")]
	[Address(RVA = "0x22E0518", Offset = "0x22E0518", VA = "0x22E0518")]
	private void OnLocDownloaded(ResErrorCode err_code, ResDownloadType type)
	{
	}

	[Token(Token = "0x6017607")]
	[Address(RVA = "0x22E05D0", Offset = "0x22E05D0", VA = "0x22E05D0")]
	private void OnOptionalCommonFileDownloaded(ResErrorCode err_code)
	{
	}

	[Token(Token = "0x6017608")]
	[Address(RVA = "0x22E0668", Offset = "0x22E0668", VA = "0x22E0668")]
	private void _003CUpdate_003Em__0()
	{
	}

	[Token(Token = "0x6017609")]
	[Address(RVA = "0x22E0678", Offset = "0x22E0678", VA = "0x22E0678")]
	private void _003CUpdate_003Em__1()
	{
	}

	[Token(Token = "0x601760A")]
	[Address(RVA = "0x22E0684", Offset = "0x22E0684", VA = "0x22E0684")]
	private void _003CRetrieveVerInfo_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601760B")]
	[Address(RVA = "0x22E2140", Offset = "0x22E2140", VA = "0x22E2140")]
	private void _003COpenFFMaxIntro_003Em__3()
	{
	}

	[Token(Token = "0x601760C")]
	[Address(RVA = "0x22E2148", Offset = "0x22E2148", VA = "0x22E2148")]
	private void _003COpenSpaceInsufficientNoticeWnd_003Em__4()
	{
	}

	[Token(Token = "0x601760D")]
	[Address(RVA = "0x22E2288", Offset = "0x22E2288", VA = "0x22E2288")]
	private void _003CCheckVersion_003Em__5(ResHotUpdateResult result)
	{
	}

	[Token(Token = "0x601760E")]
	[Address(RVA = "0x22E2460", Offset = "0x22E2460", VA = "0x22E2460")]
	private void _003CCheckVersion_003Em__6(ResHotUpdateResult result)
	{
	}

	[Token(Token = "0x601760F")]
	[Address(RVA = "0x22E2598", Offset = "0x22E2598", VA = "0x22E2598")]
	private void _003CCheckVersion_003Em__7(ResHotUpdateResult result)
	{
	}

	[Token(Token = "0x6017610")]
	[Address(RVA = "0x22E2C18", Offset = "0x22E2C18", VA = "0x22E2C18")]
	private void _003COnHotUpdateError_003Em__8()
	{
	}

	[Token(Token = "0x6017611")]
	[Address(RVA = "0x22E2F78", Offset = "0x22E2F78", VA = "0x22E2F78")]
	private void _003COnLocUpdateError_003Em__9()
	{
	}

	[Token(Token = "0x6017612")]
	[Address(RVA = "0x22E3050", Offset = "0x22E3050", VA = "0x22E3050")]
	private void _003COnLocUpdateError_003Em__A()
	{
	}

	[Token(Token = "0x6017613")]
	[Address(RVA = "0x22E3144", Offset = "0x22E3144", VA = "0x22E3144")]
	private void _003COnLocUpdateError_003Em__B()
	{
	}

	[Token(Token = "0x6017614")]
	[Address(RVA = "0x22E3228", Offset = "0x22E3228", VA = "0x22E3228")]
	private void _003COnHotUpdateFinished_003Em__C(ResErrorCode ret, ResDownloadType type)
	{
	}

	[Token(Token = "0x6017615")]
	[Address(RVA = "0x22E3510", Offset = "0x22E3510", VA = "0x22E3510")]
	private void _003CRetrieveVerInfo_003Em__D()
	{
	}

	[Token(Token = "0x6017616")]
	[Address(RVA = "0x22E3734", Offset = "0x22E3734", VA = "0x22E3734")]
	private static void _003CCheckVersion_003Em__E()
	{
	}

	[Token(Token = "0x6017617")]
	[Address(RVA = "0x22E373C", Offset = "0x22E373C", VA = "0x22E373C")]
	private void _003COnHotUpdateFinished_003Em__F()
	{
	}

	[Token(Token = "0x6017618")]
	[Address(RVA = "0x22E3C5C", Offset = "0x22E3C5C", VA = "0x22E3C5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6017619")]
	[Address(RVA = "0x22E3C64", Offset = "0x22E3C64", VA = "0x22E3C64")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x601761A")]
	[Address(RVA = "0x22E3C6C", Offset = "0x22E3C6C", VA = "0x22E3C6C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
