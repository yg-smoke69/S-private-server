using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x2003227")]
public class UIModelSceneEdit : UIBaseModel
{
	[Token(Token = "0x2003228")]
	public enum EEnterSceneEditMode
	{
		[Token(Token = "0x40131D0")]
		EMode_Default,
		[Token(Token = "0x40131D1")]
		EMode_MySlot,
		[Token(Token = "0x40131D2")]
		EMode_Preview,
		[Token(Token = "0x40131D3")]
		EMode_CreateNew
	}

	[Token(Token = "0x2003229")]
	public enum EWorkshopDownloadType
	{
		[Token(Token = "0x40131D5")]
		EWorkshopDownoadType_None,
		[Token(Token = "0x40131D6")]
		EWorkshopDownloadType_EnterGameMySlot,
		[Token(Token = "0x40131D7")]
		EWorkshopDownloadType_EnterGamePreview,
		[Token(Token = "0x40131D8")]
		EWorkshopDownloadType_LobbySaveAs
	}

	[Token(Token = "0x200322A")]
	public enum EWorkshopDelType
	{
		[Token(Token = "0x40131DA")]
		EWorkshopDelType_None,
		[Token(Token = "0x40131DB")]
		EWorkshopDelType_Local,
		[Token(Token = "0x40131DC")]
		EWorkshopDelType_Online,
		[Token(Token = "0x40131DD")]
		EWorkshopDelType_Both
	}

	[Token(Token = "0x200322B")]
	public enum EQuickSubResult
	{
		[Token(Token = "0x40131DF")]
		EDel,
		[Token(Token = "0x40131E0")]
		ESub,
		[Token(Token = "0x40131E1")]
		EFull
	}

	[Token(Token = "0x200322C")]
	public enum EWorkShopCreateRoomSrc
	{
		[Token(Token = "0x40131E3")]
		Subscription = 3,
		[Token(Token = "0x40131E4")]
		Latest = 5,
		[Token(Token = "0x40131E5")]
		Recommendation = 6,
		[Token(Token = "0x40131E6")]
		MyWorkshop = 7,
		[Token(Token = "0x40131E7")]
		Determined = 8,
		[Token(Token = "0x40131E8")]
		RoomCurrent = 9
	}

	[Token(Token = "0x200322D")]
	public class CreatorFeedBackData
	{
		[Token(Token = "0x40131E9")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_SubscriptionTimes;

		[Token(Token = "0x40131EA")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_LikedTimes;

		[Token(Token = "0x601530F")]
		[Address(RVA = "0x30DFBB0", Offset = "0x30DFBB0", VA = "0x30DFBB0")]
		public CreatorFeedBackData()
		{
		}
	}

	[Token(Token = "0x200322E")]
	private sealed class _003CHasThisCodeSubscribed_003Ec__AnonStorey0
	{
		[Token(Token = "0x40131EB")]
		[FieldOffset(Offset = "0x8")]
		internal string code;

		[Token(Token = "0x6015310")]
		[Address(RVA = "0x30DB204", Offset = "0x30DB204", VA = "0x30DB204")]
		public _003CHasThisCodeSubscribed_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015311")]
		[Address(RVA = "0x30DB20C", Offset = "0x30DB20C", VA = "0x30DB20C")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200322F")]
	private sealed class _003CIsThisCodeCanBeSubscribed_003Ec__AnonStorey1
	{
		[Token(Token = "0x40131EC")]
		[FieldOffset(Offset = "0x8")]
		internal string code;

		[Token(Token = "0x6015312")]
		[Address(RVA = "0x30DB2B0", Offset = "0x30DB2B0", VA = "0x30DB2B0")]
		public _003CIsThisCodeCanBeSubscribed_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6015313")]
		[Address(RVA = "0x30DB2B8", Offset = "0x30DB2B8", VA = "0x30DB2B8")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6015314")]
		[Address(RVA = "0x30DB35C", Offset = "0x30DB35C", VA = "0x30DB35C")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003230")]
	private sealed class _003CCanBeUpdated_003Ec__AnonStorey2
	{
		[Token(Token = "0x40131ED")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6015315")]
		[Address(RVA = "0x30DAC38", Offset = "0x30DAC38", VA = "0x30DAC38")]
		public _003CCanBeUpdated_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6015316")]
		[Address(RVA = "0x30DAC40", Offset = "0x30DAC40", VA = "0x30DAC40")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6015317")]
		[Address(RVA = "0x30DAC8C", Offset = "0x30DAC8C", VA = "0x30DAC8C")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003231")]
	private sealed class _003CGetSceneEditSlotInfoBySlotTypeAndID_003Ec__AnonStorey3
	{
		[Token(Token = "0x40131EE")]
		[FieldOffset(Offset = "0x8")]
		internal uint slotID;

		[Token(Token = "0x6015318")]
		[Address(RVA = "0x30DB114", Offset = "0x30DB114", VA = "0x30DB114")]
		public _003CGetSceneEditSlotInfoBySlotTypeAndID_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6015319")]
		[Address(RVA = "0x30DB11C", Offset = "0x30DB11C", VA = "0x30DB11C")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x601531A")]
		[Address(RVA = "0x30DB154", Offset = "0x30DB154", VA = "0x30DB154")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x601531B")]
		[Address(RVA = "0x30DB18C", Offset = "0x30DB18C", VA = "0x30DB18C")]
		internal bool _003C_003Em__2(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003232")]
	private sealed class _003CGetLocalSaveBySlotId_003Ec__AnonStorey4
	{
		[Token(Token = "0x40131EF")]
		[FieldOffset(Offset = "0x8")]
		internal uint slotId;

		[Token(Token = "0x601531C")]
		[Address(RVA = "0x30DB0D4", Offset = "0x30DB0D4", VA = "0x30DB0D4")]
		public _003CGetLocalSaveBySlotId_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x601531D")]
		[Address(RVA = "0x30DB0DC", Offset = "0x30DB0DC", VA = "0x30DB0DC")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003233")]
	private sealed class _003CUpdateAuthorAndLocalSaveSlot_003Ec__AnonStorey5
	{
		[Token(Token = "0x40131F0")]
		[FieldOffset(Offset = "0x8")]
		internal uint slotId;

		[Token(Token = "0x601531E")]
		[Address(RVA = "0x30DFB38", Offset = "0x30DFB38", VA = "0x30DFB38")]
		public _003CUpdateAuthorAndLocalSaveSlot_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x601531F")]
		[Address(RVA = "0x30DFB40", Offset = "0x30DFB40", VA = "0x30DFB40")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6015320")]
		[Address(RVA = "0x30DFB78", Offset = "0x30DFB78", VA = "0x30DFB78")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003234")]
	private sealed class _003CCopyLocalSaveTo_003Ec__AnonStorey6
	{
		[Token(Token = "0x40131F1")]
		[FieldOffset(Offset = "0x8")]
		internal uint srcSlotId;

		[Token(Token = "0x40131F2")]
		[FieldOffset(Offset = "0xC")]
		internal uint destSlotId;

		[Token(Token = "0x6015321")]
		[Address(RVA = "0x30DAFBC", Offset = "0x30DAFBC", VA = "0x30DAFBC")]
		public _003CCopyLocalSaveTo_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6015322")]
		[Address(RVA = "0x30DAFC4", Offset = "0x30DAFC4", VA = "0x30DAFC4")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6015323")]
		[Address(RVA = "0x30DAFFC", Offset = "0x30DAFFC", VA = "0x30DAFFC")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003235")]
	private sealed class _003CRequestUploadWorkshopCDN_003Ec__AnonStorey7
	{
		[Token(Token = "0x40131F3")]
		[FieldOffset(Offset = "0x8")]
		internal SceneEditSlotInfo slot;

		[Token(Token = "0x40131F4")]
		[FieldOffset(Offset = "0xC")]
		internal SceneEditSlotInfo localSave;

		[Token(Token = "0x40131F5")]
		[FieldOffset(Offset = "0x10")]
		internal bool update;

		[Token(Token = "0x40131F6")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x6015324")]
		[Address(RVA = "0x30DEDA8", Offset = "0x30DEDA8", VA = "0x30DEDA8")]
		public _003CRequestUploadWorkshopCDN_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6015325")]
		[Address(RVA = "0x30DEDB0", Offset = "0x30DEDB0", VA = "0x30DEDB0")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6015326")]
		[Address(RVA = "0x30DEDFC", Offset = "0x30DEDFC", VA = "0x30DEDFC")]
		internal void _003C_003Em__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003236")]
	private sealed class _003COnUploadCDNSuccResponse_003Ec__AnonStorey8
	{
		[Token(Token = "0x40131F7")]
		[FieldOffset(Offset = "0x8")]
		internal PGBGOAOCGDC info;

		[Token(Token = "0x6015327")]
		[Address(RVA = "0x30DB400", Offset = "0x30DB400", VA = "0x30DB400")]
		public _003COnUploadCDNSuccResponse_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6015328")]
		[Address(RVA = "0x30DB408", Offset = "0x30DB408", VA = "0x30DB408")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6015329")]
		[Address(RVA = "0x30DB460", Offset = "0x30DB460", VA = "0x30DB460")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x601532A")]
		[Address(RVA = "0x30DB4B8", Offset = "0x30DB4B8", VA = "0x30DB4B8")]
		internal bool _003C_003Em__2(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003237")]
	private sealed class _003CRequestDownloadWorkshopCDN_003Ec__AnonStorey9
	{
		[Token(Token = "0x40131F8")]
		[FieldOffset(Offset = "0x8")]
		internal EWorkshopDownloadType downloadType;

		[Token(Token = "0x40131F9")]
		[FieldOffset(Offset = "0xC")]
		internal EWorkshop.SlotType slotType;

		[Token(Token = "0x40131FA")]
		[FieldOffset(Offset = "0x10")]
		internal uint slotID;

		[Token(Token = "0x40131FB")]
		[FieldOffset(Offset = "0x14")]
		internal uint destId;

		[Token(Token = "0x40131FC")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x601532B")]
		[Address(RVA = "0x30DC28C", Offset = "0x30DC28C", VA = "0x30DC28C")]
		public _003CRequestDownloadWorkshopCDN_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x601532C")]
		[Address(RVA = "0x30DC294", Offset = "0x30DC294", VA = "0x30DC294")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003238")]
	private sealed class _003CHandleDownloadLobbySaveAs_003Ec__AnonStoreyA
	{
		[Token(Token = "0x40131FD")]
		[FieldOffset(Offset = "0x8")]
		internal uint destId;

		[Token(Token = "0x601532D")]
		[Address(RVA = "0x30DB1C4", Offset = "0x30DB1C4", VA = "0x30DB1C4")]
		public _003CHandleDownloadLobbySaveAs_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x601532E")]
		[Address(RVA = "0x30DB1CC", Offset = "0x30DB1CC", VA = "0x30DB1CC")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003239")]
	private sealed class _003CRequestUploadDescInfo_003Ec__AnonStoreyB
	{
		[Token(Token = "0x40131FE")]
		[FieldOffset(Offset = "0x8")]
		internal string desc;

		[Token(Token = "0x40131FF")]
		[FieldOffset(Offset = "0xC")]
		internal SceneEditSlotInfo info;

		[Token(Token = "0x4013200")]
		[FieldOffset(Offset = "0x10")]
		internal string name;

		[Token(Token = "0x4013201")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x601532F")]
		[Address(RVA = "0x30DE538", Offset = "0x30DE538", VA = "0x30DE538")]
		public _003CRequestUploadDescInfo_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6015330")]
		[Address(RVA = "0x30DE540", Offset = "0x30DE540", VA = "0x30DE540")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015331")]
		[Address(RVA = "0x30DED10", Offset = "0x30DED10", VA = "0x30DED10")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6015332")]
		[Address(RVA = "0x30DED5C", Offset = "0x30DED5C", VA = "0x30DED5C")]
		internal bool _003C_003Em__2(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200323A")]
	private sealed class _003CProcessLocalSaveOnNameChange_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4013202")]
		[FieldOffset(Offset = "0x8")]
		internal SceneEditSlotInfo info;

		[Token(Token = "0x6015333")]
		[Address(RVA = "0x30DB550", Offset = "0x30DB550", VA = "0x30DB550")]
		public _003CProcessLocalSaveOnNameChange_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6015334")]
		[Address(RVA = "0x30DB558", Offset = "0x30DB558", VA = "0x30DB558")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200323B")]
	private sealed class _003CProcessLocalSaveOnDel_003Ec__AnonStoreyD
	{
		[Token(Token = "0x4013203")]
		[FieldOffset(Offset = "0x8")]
		internal uint slotId;

		[Token(Token = "0x6015335")]
		[Address(RVA = "0x30DB510", Offset = "0x30DB510", VA = "0x30DB510")]
		public _003CProcessLocalSaveOnDel_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x6015336")]
		[Address(RVA = "0x30DB518", Offset = "0x30DB518", VA = "0x30DB518")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200323C")]
	private sealed class _003CRequestDel_003Ec__AnonStorey14
	{
		[Token(Token = "0x200323D")]
		private sealed class _003CRequestDel_003Ec__AnonStorey15
		{
			[Token(Token = "0x4013208")]
			[FieldOffset(Offset = "0x8")]
			internal uint slot_id;

			[Token(Token = "0x4013209")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestDel_003Ec__AnonStorey14 _003C_003Ef__ref_002420;

			[Token(Token = "0x6015339")]
			[Address(RVA = "0x30DC214", Offset = "0x30DC214", VA = "0x30DC214")]
			public _003CRequestDel_003Ec__AnonStorey15()
			{
			}

			[Token(Token = "0x601533A")]
			[Address(RVA = "0x30DC21C", Offset = "0x30DC21C", VA = "0x30DC21C")]
			internal bool _003C_003Em__0(SceneEditSlotInfo e)
			{
				return default(bool);
			}

			[Token(Token = "0x601533B")]
			[Address(RVA = "0x30DC254", Offset = "0x30DC254", VA = "0x30DC254")]
			internal bool _003C_003Em__1(SceneEditSlotInfo e)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4013204")]
		[FieldOffset(Offset = "0x8")]
		internal EWorkshop.SlotType type;

		[Token(Token = "0x4013205")]
		[FieldOffset(Offset = "0xC")]
		internal uint id;

		[Token(Token = "0x4013206")]
		[FieldOffset(Offset = "0x10")]
		internal EWorkshopDelType delType;

		[Token(Token = "0x4013207")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x6015337")]
		[Address(RVA = "0x30DB99C", Offset = "0x30DB99C", VA = "0x30DB99C")]
		public _003CRequestDel_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x6015338")]
		[Address(RVA = "0x30DB9A4", Offset = "0x30DB9A4", VA = "0x30DB9A4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200323E")]
	private sealed class _003CTryRequestQuickSubscribeOrDel_003Ec__AnonStorey16
	{
		[Token(Token = "0x401320A")]
		[FieldOffset(Offset = "0x8")]
		internal string code;

		[Token(Token = "0x601533C")]
		[Address(RVA = "0x30DFA8C", Offset = "0x30DFA8C", VA = "0x30DFA8C")]
		public _003CTryRequestQuickSubscribeOrDel_003Ec__AnonStorey16()
		{
		}

		[Token(Token = "0x601533D")]
		[Address(RVA = "0x30DFA94", Offset = "0x30DFA94", VA = "0x30DFA94")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200323F")]
	private sealed class _003CRequestSubscribe_003Ec__AnonStorey17
	{
		[Token(Token = "0x401320B")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x401320C")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x601533E")]
		[Address(RVA = "0x30DE120", Offset = "0x30DE120", VA = "0x30DE120")]
		public _003CRequestSubscribe_003Ec__AnonStorey17()
		{
		}

		[Token(Token = "0x601533F")]
		[Address(RVA = "0x30DE128", Offset = "0x30DE128", VA = "0x30DE128")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015340")]
		[Address(RVA = "0x30DE458", Offset = "0x30DE458", VA = "0x30DE458")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003240")]
	private sealed class _003CRequestPreview_003Ec__AnonStorey18
	{
		[Token(Token = "0x401320D")]
		[FieldOffset(Offset = "0x8")]
		internal string previewCode;

		[Token(Token = "0x401320E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x6015341")]
		[Address(RVA = "0x30DD258", Offset = "0x30DD258", VA = "0x30DD258")]
		public _003CRequestPreview_003Ec__AnonStorey18()
		{
		}

		[Token(Token = "0x6015342")]
		[Address(RVA = "0x30DD260", Offset = "0x30DD260", VA = "0x30DD260")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003241")]
	private sealed class _003CRequestCheckShareCode_003Ec__AnonStorey1A
	{
		[Token(Token = "0x401320F")]
		[FieldOffset(Offset = "0x8")]
		internal int area;

		[Token(Token = "0x4013210")]
		[FieldOffset(Offset = "0xC")]
		internal bool isLogin;

		[Token(Token = "0x4013211")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x6015343")]
		[Address(RVA = "0x30DB994", Offset = "0x30DB994", VA = "0x30DB994")]
		public _003CRequestCheckShareCode_003Ec__AnonStorey1A()
		{
		}
	}

	[Token(Token = "0x2003242")]
	private sealed class _003CRequestCheckShareCode_003Ec__AnonStorey19
	{
		[Token(Token = "0x4013212")]
		[FieldOffset(Offset = "0x8")]
		internal CSSearchWorkshopCodeReq req;

		[Token(Token = "0x4013213")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRequestCheckShareCode_003Ec__AnonStorey1A _003C_003Ef__ref_002426;

		[Token(Token = "0x6015344")]
		[Address(RVA = "0x30DB5A4", Offset = "0x30DB5A4", VA = "0x30DB5A4")]
		public _003CRequestCheckShareCode_003Ec__AnonStorey19()
		{
		}

		[Token(Token = "0x6015345")]
		[Address(RVA = "0x30DB5AC", Offset = "0x30DB5AC", VA = "0x30DB5AC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003243")]
	private sealed class _003CRequestSearch_003Ec__AnonStorey1B
	{
		[Token(Token = "0x4013214")]
		[FieldOffset(Offset = "0x8")]
		internal string workshopCode;

		[Token(Token = "0x4013215")]
		[FieldOffset(Offset = "0xC")]
		internal bool isGMPreview;

		[Token(Token = "0x4013216")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x6015346")]
		[Address(RVA = "0x30DDB80", Offset = "0x30DDB80", VA = "0x30DDB80")]
		public _003CRequestSearch_003Ec__AnonStorey1B()
		{
		}

		[Token(Token = "0x6015347")]
		[Address(RVA = "0x30DDB88", Offset = "0x30DDB88", VA = "0x30DDB88")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003244")]
	private sealed class _003CRequestReport_003Ec__AnonStorey1C
	{
		[Token(Token = "0x4013217")]
		[FieldOffset(Offset = "0x8")]
		internal string code;

		[Token(Token = "0x4013218")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x6015348")]
		[Address(RVA = "0x30DDA68", Offset = "0x30DDA68", VA = "0x30DDA68")]
		public _003CRequestReport_003Ec__AnonStorey1C()
		{
		}

		[Token(Token = "0x6015349")]
		[Address(RVA = "0x30DDA70", Offset = "0x30DDA70", VA = "0x30DDA70")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003245")]
	private sealed class _003CCheckLevelCanRewarded_003Ec__AnonStorey1D
	{
		[Token(Token = "0x4013219")]
		[FieldOffset(Offset = "0x8")]
		internal uint level;

		[Token(Token = "0x401321A")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x601534A")]
		[Address(RVA = "0x30DACC4", Offset = "0x30DACC4", VA = "0x30DACC4")]
		public _003CCheckLevelCanRewarded_003Ec__AnonStorey1D()
		{
		}

		[Token(Token = "0x601534B")]
		[Address(RVA = "0x30DACCC", Offset = "0x30DACCC", VA = "0x30DACCC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003246")]
	private sealed class _003CRequestEditorChoiceById_003Ec__AnonStorey1E
	{
		[Token(Token = "0x401321B")]
		[FieldOffset(Offset = "0x8")]
		internal List<WorkshopEditorChoiceInfo> resList;

		[Token(Token = "0x401321C")]
		[FieldOffset(Offset = "0xC")]
		internal uint id;

		[Token(Token = "0x401321D")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x401321E")]
		[FieldOffset(Offset = "0x0")]
		private static Comparison<WorkshopEditorChoiceInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x601534C")]
		[Address(RVA = "0x30DCD24", Offset = "0x30DCD24", VA = "0x30DCD24")]
		public _003CRequestEditorChoiceById_003Ec__AnonStorey1E()
		{
		}

		[Token(Token = "0x601534D")]
		[Address(RVA = "0x30DCD2C", Offset = "0x30DCD2C", VA = "0x30DCD2C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601534E")]
		[Address(RVA = "0x30DD210", Offset = "0x30DD210", VA = "0x30DD210")]
		private static int _003C_003Em__1(WorkshopEditorChoiceInfo a, WorkshopEditorChoiceInfo b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2003247")]
	private sealed class _003CRequestSelfdomInfo_003Ec__AnonStorey1F
	{
		[Token(Token = "0x401321F")]
		[FieldOffset(Offset = "0x8")]
		internal bool isFirst;

		[Token(Token = "0x4013220")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelSceneEdit _0024this;

		[Token(Token = "0x601534F")]
		[Address(RVA = "0x30DDDF8", Offset = "0x30DDDF8", VA = "0x30DDDF8")]
		public _003CRequestSelfdomInfo_003Ec__AnonStorey1F()
		{
		}

		[Token(Token = "0x6015350")]
		[Address(RVA = "0x30DDE00", Offset = "0x30DDE00", VA = "0x30DDE00")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003248")]
	private sealed class _003CGetCreateRoomSlotInfos_003Ec__AnonStorey20
	{
		[Token(Token = "0x4013221")]
		[FieldOffset(Offset = "0x8")]
		internal SceneEditSlotInfo slot;

		[Token(Token = "0x6015351")]
		[Address(RVA = "0x30DB034", Offset = "0x30DB034", VA = "0x30DB034")]
		public _003CGetCreateRoomSlotInfos_003Ec__AnonStorey20()
		{
		}

		[Token(Token = "0x6015352")]
		[Address(RVA = "0x30DB03C", Offset = "0x30DB03C", VA = "0x30DB03C")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6015353")]
		[Address(RVA = "0x30DB088", Offset = "0x30DB088", VA = "0x30DB088")]
		internal bool _003C_003Em__1(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003249")]
	private sealed class _003CRequestSlotInfo_003Ec__AnonStoreyE
	{
		[Token(Token = "0x4013222")]
		[FieldOffset(Offset = "0x8")]
		internal WorkshopSubscribeSlotInfo slot;

		[Token(Token = "0x6015354")]
		[Address(RVA = "0x30DE078", Offset = "0x30DE078", VA = "0x30DE078")]
		public _003CRequestSlotInfo_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x6015355")]
		[Address(RVA = "0x30DE080", Offset = "0x30DE080", VA = "0x30DE080")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200324A")]
	private sealed class _003CRequestSlotInfo_003Ec__AnonStoreyF
	{
		[Token(Token = "0x4013223")]
		[FieldOffset(Offset = "0x8")]
		internal WorkshopAuthorSlotInfo slot;

		[Token(Token = "0x6015356")]
		[Address(RVA = "0x30DE0CC", Offset = "0x30DE0CC", VA = "0x30DE0CC")]
		public _003CRequestSlotInfo_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x6015357")]
		[Address(RVA = "0x30DE0D4", Offset = "0x30DE0D4", VA = "0x30DE0D4")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200324B")]
	private sealed class _003CRequestSlotInfo_003Ec__AnonStorey10
	{
		[Token(Token = "0x4013224")]
		[FieldOffset(Offset = "0x8")]
		internal SceneEditSlotInfo slot;

		[Token(Token = "0x6015358")]
		[Address(RVA = "0x30DE024", Offset = "0x30DE024", VA = "0x30DE024")]
		public _003CRequestSlotInfo_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x6015359")]
		[Address(RVA = "0x30DE02C", Offset = "0x30DE02C", VA = "0x30DE02C")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200324C")]
	private sealed class _003CRequestSubscriptionSlotInfo_003Ec__AnonStorey11
	{
		[Token(Token = "0x4013225")]
		[FieldOffset(Offset = "0x8")]
		internal WorkshopSubscribeSlotInfo slot;

		[Token(Token = "0x601535A")]
		[Address(RVA = "0x30DE490", Offset = "0x30DE490", VA = "0x30DE490")]
		public _003CRequestSubscriptionSlotInfo_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x601535B")]
		[Address(RVA = "0x30DE498", Offset = "0x30DE498", VA = "0x30DE498")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200324D")]
	private sealed class _003CRequestUnlock_003Ec__AnonStorey12
	{
		[Token(Token = "0x4013226")]
		[FieldOffset(Offset = "0x8")]
		internal CSUnlockWorkshopSlotRes data;

		[Token(Token = "0x601535C")]
		[Address(RVA = "0x30DE4E4", Offset = "0x30DE4E4", VA = "0x30DE4E4")]
		public _003CRequestUnlock_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x601535D")]
		[Address(RVA = "0x30DE4EC", Offset = "0x30DE4EC", VA = "0x30DE4EC")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200324E")]
	private sealed class _003CRequestShare_003Ec__AnonStorey13
	{
		[Token(Token = "0x4013227")]
		[FieldOffset(Offset = "0x8")]
		internal uint slot_id;

		[Token(Token = "0x601535E")]
		[Address(RVA = "0x30DDFE4", Offset = "0x30DDFE4", VA = "0x30DDFE4")]
		public _003CRequestShare_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x601535F")]
		[Address(RVA = "0x30DDFEC", Offset = "0x30DDFEC", VA = "0x30DDFEC")]
		internal bool _003C_003Em__0(SceneEditSlotInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4013153")]
	private const int SCENE_EDIT_SUBSCRIPTION_SLOT_CNT = 10;

	[Token(Token = "0x4013154")]
	private const int SCENE_EDIT_SHARECODE_LEN = 45;

	[Token(Token = "0x4013155")]
	private const int FIRST_REQ_SELFDOMINFO_CD = 400;

	[Token(Token = "0x4013156")]
	private const int REFRESH_SELFDOMINFO_CD = 60;

	[Token(Token = "0x4013157")]
	public const uint PropID_UploadFinish = 1u;

	[Token(Token = "0x4013158")]
	public const uint PropID_DownloadFinish = 2u;

	[Token(Token = "0x4013159")]
	public const uint PropID_RefreshSlotInfo = 4u;

	[Token(Token = "0x401315A")]
	public const uint PropID_ShareFinished = 8u;

	[Token(Token = "0x401315B")]
	public const uint PropID_SearchFinished = 16u;

	[Token(Token = "0x401315C")]
	public const uint PropID_SubscribeFinieshed = 32u;

	[Token(Token = "0x401315D")]
	public const uint PropID_UnlockFinished = 64u;

	[Token(Token = "0x401315E")]
	public const uint PropID_RefreshRecommendationInfo = 128u;

	[Token(Token = "0x401315F")]
	public const uint PropID_RefreshLatestInfo = 256u;

	[Token(Token = "0x4013160")]
	public const uint PropID_RefreshHistoryInfo = 512u;

	[Token(Token = "0x4013161")]
	public const uint PropID_GetCreateRoomRuleFinish = 1024u;

	[Token(Token = "0x4013162")]
	public const uint PropID_RefreshDescInfo = 2048u;

	[Token(Token = "0x4013163")]
	public const uint PropID_RefreshSlotNameInfo = 4096u;

	[Token(Token = "0x4013164")]
	public const uint PropID_RefreshSelfdomInfo = 8192u;

	[Token(Token = "0x4013165")]
	public const uint PropID_DelFinished = 16384u;

	[Token(Token = "0x4013166")]
	public const uint PropID_DirtyWordFailed = 32768u;

	[Token(Token = "0x4013167")]
	public const uint PropID_SaveAsFinished = 65536u;

	[Token(Token = "0x4013168")]
	public const uint PropID_UpdateWorkShopRoomCard = 131072u;

	[Token(Token = "0x4013169")]
	public const uint PropID_CommentFinished = 262144u;

	[Token(Token = "0x401316A")]
	public const uint PropID_EditorChoiceInfoRefresh = 524288u;

	[Token(Token = "0x401316B")]
	[FieldOffset(Offset = "0xC")]
	private readonly Dictionary<int, OAMCFBDOEHM.BFIGPFKKAGK> m_EditorErrorConfig;

	[Token(Token = "0x401316C")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, WorkshopShowMapIconData> m_WorkShopMapIconMap;

	[Token(Token = "0x401316D")]
	[FieldOffset(Offset = "0x14")]
	private Action m_OnReturnToLobbyCallback;

	[Token(Token = "0x401316E")]
	[FieldOffset(Offset = "0x18")]
	private ulong m_LastUploadTime;

	[Token(Token = "0x401316F")]
	[FieldOffset(Offset = "0x20")]
	private ulong m_LastApplyTime;

	[Token(Token = "0x4013170")]
	[FieldOffset(Offset = "0x28")]
	private ulong m_LastUploadDescTime;

	[Token(Token = "0x4013171")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_LastUploadSlotNameTime;

	[Token(Token = "0x4013172")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_LastShareTime;

	[Token(Token = "0x4013173")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_LastSearchTime;

	[Token(Token = "0x4013174")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HasEnterSceneEdit;

	[Token(Token = "0x4013175")]
	[FieldOffset(Offset = "0x4C")]
	public uint InGameEditSlotId;

	[Token(Token = "0x4013176")]
	[FieldOffset(Offset = "0x50")]
	public bool InGameEditNeedDownload;

	[Token(Token = "0x4013177")]
	[FieldOffset(Offset = "0x54")]
	public uint InGameEditMapId;

	[Token(Token = "0x4013178")]
	[FieldOffset(Offset = "0x58")]
	public uint InGameEditModeId;

	[Token(Token = "0x4013179")]
	[FieldOffset(Offset = "0x5C")]
	public uint InGameEditModeTemplate;

	[Token(Token = "0x401317A")]
	[FieldOffset(Offset = "0x60")]
	private bool m_UseServerData;

	[Token(Token = "0x401317B")]
	[FieldOffset(Offset = "0x68")]
	private ulong m_PlayerEnterSceneEditTime;

	[Token(Token = "0x401317C")]
	[FieldOffset(Offset = "0x70")]
	private uint m_PlayerHideItemListCnt;

	[Token(Token = "0x401317D")]
	[FieldOffset(Offset = "0x78")]
	private ulong m_PlayerHideItemListStart;

	[Token(Token = "0x401317E")]
	[FieldOffset(Offset = "0x80")]
	private uint m_PlayerHideItemListTime;

	[Token(Token = "0x401317F")]
	[FieldOffset(Offset = "0x84")]
	private uint m_PlayerChangeEditTypeCnt;

	[Token(Token = "0x4013180")]
	[FieldOffset(Offset = "0x88")]
	private ulong m_PlayerFreeEditTotalTime;

	[Token(Token = "0x4013181")]
	[FieldOffset(Offset = "0x90")]
	private ulong m_PlayerFreeEditStartTime;

	[Token(Token = "0x4013182")]
	[FieldOffset(Offset = "0x98")]
	private uint mAdjustFloorUpTimes;

	[Token(Token = "0x4013183")]
	[FieldOffset(Offset = "0x9C")]
	private uint mAdjustFloorDownTimes;

	[Token(Token = "0x4013184")]
	[FieldOffset(Offset = "0xA0")]
	private float mAdjustFloorMaxHeight;

	[Token(Token = "0x4013185")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_PlayerTopViewTime;

	[Token(Token = "0x4013186")]
	[FieldOffset(Offset = "0xA8")]
	private ulong m_PlayerTopViewStartTime;

	[Token(Token = "0x4013187")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_PlayerTopViewCnt;

	[Token(Token = "0x4013188")]
	[FieldOffset(Offset = "0xB8")]
	private ulong m_IntersectionEditStartTime;

	[Token(Token = "0x4013189")]
	[FieldOffset(Offset = "0xC0")]
	private ulong m_IntersectionEditTotalTime;

	[Token(Token = "0x401318A")]
	[FieldOffset(Offset = "0xC8")]
	private uint m_SaveCount;

	[Token(Token = "0x401318B")]
	[FieldOffset(Offset = "0xCC")]
	private readonly Dictionary<uint, uint> m_SaveErrorInfos;

	[Token(Token = "0x401318C")]
	[FieldOffset(Offset = "0xD0")]
	private ulong lastUpdateTime;

	[Token(Token = "0x401318D")]
	private const int m_CDSecond = 60;

	[Token(Token = "0x401318E")]
	[FieldOffset(Offset = "0xD8")]
	private ulong m_FirstReqSelfdomInfoTime;

	[Token(Token = "0x401318F")]
	[FieldOffset(Offset = "0xE0")]
	private ulong m_RefreshSelfdomInfoTime;

	[Token(Token = "0x4013190")]
	[FieldOffset(Offset = "0xE8")]
	private CSGetWorkshopPersonalRecommendationInfoRes m_SelfdomInfoRes;

	[Token(Token = "0x4013191")]
	[FieldOffset(Offset = "0xEC")]
	private bool m_HasRequestInited;

	[Token(Token = "0x4013192")]
	[FieldOffset(Offset = "0xF0")]
	private List<SceneEditSlotInfo> m_SubscriptionSlotList;

	[Token(Token = "0x4013193")]
	[FieldOffset(Offset = "0xF4")]
	private List<SceneEditSlotInfo> m_ClassicSlotList;

	[Token(Token = "0x4013194")]
	[FieldOffset(Offset = "0xF8")]
	private List<SceneEditSlotInfo> m_AuthorSlotList;

	[Token(Token = "0x4013195")]
	[FieldOffset(Offset = "0xFC")]
	private CreateWorkshopRoomInfo m_CreateWorkshopRoomInfo;

	[Token(Token = "0x4013196")]
	[FieldOffset(Offset = "0x100")]
	private List<SceneEditSlotInfo> m_AuthorLocalSaveSlotList;

	[Token(Token = "0x4013197")]
	[FieldOffset(Offset = "0x104")]
	private SceneEditSlotInfo m_LatestSearchSlotInfo;

	[Token(Token = "0x4013198")]
	[FieldOffset(Offset = "0x108")]
	private uint m_LatestSelectedSlotID;

	[Token(Token = "0x4013199")]
	[FieldOffset(Offset = "0x10C")]
	private HashSet<string> m_ReportedCode;

	[Token(Token = "0x401319A")]
	[FieldOffset(Offset = "0x110")]
	private List<WorkshopHotInfo> m_HotWorkshopInfoList;

	[Token(Token = "0x401319B")]
	[FieldOffset(Offset = "0x114")]
	private List<WorkshopEditorChoiceDesc> m_EditorChoiceRecDescList;

	[Token(Token = "0x401319C")]
	[FieldOffset(Offset = "0x118")]
	private Dictionary<uint, List<WorkshopEditorChoiceInfo>> m_EditorChoiceRecInfoDic;

	[Token(Token = "0x401319D")]
	[FieldOffset(Offset = "0x11C")]
	private List<SceneEditSlotInfo> m_RecommendWorkshopInfoList;

	[Token(Token = "0x401319E")]
	[FieldOffset(Offset = "0x120")]
	private HashSet<string> m_HotWorkShopMapSet;

	[Token(Token = "0x401319F")]
	[FieldOffset(Offset = "0x124")]
	private Dictionary<string, string> m_ShareCodeToCDNUrlDic;

	[Token(Token = "0x40131A0")]
	[FieldOffset(Offset = "0x128")]
	private Dictionary<string, ulong> m_ShareCodeToCommentDic;

	[Token(Token = "0x40131A1")]
	[FieldOffset(Offset = "0x12C")]
	private WorkshopAccountInfo m_WorkShopAccountInfo;

	[Token(Token = "0x40131A2")]
	[FieldOffset(Offset = "0x130")]
	private bool m_IsBanned;

	[Token(Token = "0x40131A3")]
	[FieldOffset(Offset = "0x131")]
	private bool m_IsManager;

	[Token(Token = "0x40131A4")]
	[FieldOffset(Offset = "0x134")]
	private string m_PreviewCode;

	[Token(Token = "0x40131A5")]
	[FieldOffset(Offset = "0x138")]
	private SceneEditSlotInfo m_PreviewSlotInfo;

	[Token(Token = "0x40131A6")]
	[FieldOffset(Offset = "0x13C")]
	private EOpenWorkshopDetailFrom m_WorkshopDetailWndFrom;

	[Token(Token = "0x40131A7")]
	[FieldOffset(Offset = "0x140")]
	private int m_WorkshopDetailWndTab;

	[Token(Token = "0x40131A8")]
	[FieldOffset(Offset = "0x144")]
	private EEnterEditFrom m_enterEditFrom;

	[Token(Token = "0x40131A9")]
	[FieldOffset(Offset = "0x148")]
	private bool m_IsClipboardCodeValid;

	[Token(Token = "0x40131AA")]
	[FieldOffset(Offset = "0x14C")]
	private SceneEditSlotInfo m_WorkshopCodeInfoForClipboard;

	[Token(Token = "0x40131AB")]
	[FieldOffset(Offset = "0x150")]
	private HashSet<string> m_ClipboardCodeSet;

	[Token(Token = "0x40131AC")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, int> m_NavigationPageTypeDict;

	[Token(Token = "0x40131AD")]
	[FieldOffset(Offset = "0x154")]
	public bool AutoEnterEditModeNext;

	[Token(Token = "0x40131AE")]
	[FieldOffset(Offset = "0x158")]
	public Vector3 AutoMovePlayerToPos;

	[Token(Token = "0x40131AF")]
	[FieldOffset(Offset = "0x164")]
	public EEnterSceneEditMode CurrentEnterSceneEditMode;

	[Token(Token = "0x40131B0")]
	[FieldOffset(Offset = "0x168")]
	public UIModelSceneEdit_CDNUpload m_curUploadingCDN;

	[Token(Token = "0x40131B1")]
	[FieldOffset(Offset = "0x16C")]
	public UIModelSceneEdit_CDNDownLoad m_curDownloadingCDN;

	[Token(Token = "0x40131B2")]
	[FieldOffset(Offset = "0x170")]
	private bool m_HasPredownloadRequested;

	[Token(Token = "0x40131B3")]
	[FieldOffset(Offset = "0x174")]
	private List<WorkshopCustomModeTemplateRuleDesc> m_UGCCustomModeTemplateRuleDataList;

	[Token(Token = "0x40131B4")]
	[FieldOffset(Offset = "0x178")]
	private Queue<ulong> m_TimestampQueue;

	[Token(Token = "0x40131B5")]
	[FieldOffset(Offset = "0x17C")]
	private bool m_LastMySlotDownloadFailed;

	[Token(Token = "0x40131B6")]
	[FieldOffset(Offset = "0x180")]
	private int m_MyMaxCost;

	[Token(Token = "0x40131B7")]
	[FieldOffset(Offset = "0x184")]
	private List<SceneEditSlotInfo> m_LatestInfoList;

	[Token(Token = "0x40131B8")]
	[FieldOffset(Offset = "0x188")]
	public List<SceneEditSlotInfo> DeterminedSlotInfo;

	[Token(Token = "0x40131B9")]
	[FieldOffset(Offset = "0x18C")]
	private List<UGCRemarkRuleData> m_RemarkRuleDataList;

	[Token(Token = "0x40131BA")]
	[FieldOffset(Offset = "0x190")]
	private CreatorFeedBackData m_LastSaveCFData;

	[Token(Token = "0x40131BB")]
	private const string LastSaveCFTimeStampKey = "LastSaveCFTimeStampKey";

	[Token(Token = "0x40131BC")]
	private const string LastCFDataKey = "LastCFDataKey";

	[Token(Token = "0x40131BD")]
	private const string HasOpenedUserAgreement = "HasOpenedUserAgreement";

	[Token(Token = "0x40131BE")]
	[FieldOffset(Offset = "0x194")]
	private int m_RecordHasOpendUserAgreement;

	[Token(Token = "0x40131BF")]
	[FieldOffset(Offset = "0x4")]
	private static Func<SceneEditSlotInfo, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40131C0")]
	[FieldOffset(Offset = "0x8")]
	private static Func<SceneEditSlotInfo, bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40131C1")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<SceneEditSlotInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40131C2")]
	[FieldOffset(Offset = "0x10")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40131C3")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<SceneEditObjectBase> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40131C4")]
	[FieldOffset(Offset = "0x18")]
	private static Predicate<SceneEditSlotInfo> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x40131C5")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<SceneEditSlotInfo> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x40131C6")]
	[FieldOffset(Offset = "0x20")]
	private static Predicate<SceneEditSlotInfo> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x40131C7")]
	[FieldOffset(Offset = "0x24")]
	private static Comparison<UGCRemarkRuleData> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x40131C8")]
	[FieldOffset(Offset = "0x28")]
	private static Predicate<SceneEditSlotInfo> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x40131C9")]
	[FieldOffset(Offset = "0x2C")]
	private static Comparison<SceneEditSlotInfo> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x40131CA")]
	[FieldOffset(Offset = "0x30")]
	private static Comparison<SceneEditSlotInfo> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x40131CB")]
	[FieldOffset(Offset = "0x34")]
	private static Comparison<SceneEditSlotInfo> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x40131CC")]
	[FieldOffset(Offset = "0x38")]
	private static Comparison<SceneEditSlotInfo> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x40131CD")]
	[FieldOffset(Offset = "0x3C")]
	private static Comparison<WorkshopHotInfo> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x40131CE")]
	[FieldOffset(Offset = "0x40")]
	private static Comparison<WorkshopEditorChoiceDesc> _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x17001645")]
	private JPPGAJBAAKK OwnerGame
	{
		[Token(Token = "0x6015231")]
		[Address(RVA = "0x2D00828", Offset = "0x2D00828", VA = "0x2D00828")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001646")]
	public Dictionary<int, OAMCFBDOEHM.BFIGPFKKAGK> EditorErrorConfig
	{
		[Token(Token = "0x6015232")]
		[Address(RVA = "0x2D00948", Offset = "0x2D00948", VA = "0x2D00948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001647")]
	public Action OnReturnToLobbyCallback
	{
		[Token(Token = "0x6015233")]
		[Address(RVA = "0x2D009A0", Offset = "0x2D009A0", VA = "0x2D009A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001648")]
	public ulong LastUploadTime
	{
		[Token(Token = "0x6015234")]
		[Address(RVA = "0x2D00A00", Offset = "0x2D00A00", VA = "0x2D00A00")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001649")]
	public ulong LastApplyTime
	{
		[Token(Token = "0x6015235")]
		[Address(RVA = "0x2D00A58", Offset = "0x2D00A58", VA = "0x2D00A58")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700164A")]
	public ulong LastUploadDescTime
	{
		[Token(Token = "0x6015236")]
		[Address(RVA = "0x2D00AB0", Offset = "0x2D00AB0", VA = "0x2D00AB0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700164B")]
	public ulong LastUploadSlotNameTime
	{
		[Token(Token = "0x6015237")]
		[Address(RVA = "0x2D00B08", Offset = "0x2D00B08", VA = "0x2D00B08")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700164C")]
	public ulong LastShareTime
	{
		[Token(Token = "0x6015238")]
		[Address(RVA = "0x2D00B60", Offset = "0x2D00B60", VA = "0x2D00B60")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700164D")]
	public ulong LastSearchTime
	{
		[Token(Token = "0x6015239")]
		[Address(RVA = "0x2D00BB8", Offset = "0x2D00BB8", VA = "0x2D00BB8")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x1700164E")]
	public bool HasEnterSceneEdit
	{
		[Token(Token = "0x601523A")]
		[Address(RVA = "0x2D00C10", Offset = "0x2D00C10", VA = "0x2D00C10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700164F")]
	public string PreviewCode
	{
		[Token(Token = "0x6015242")]
		[Address(RVA = "0x2D0148C", Offset = "0x2D0148C", VA = "0x2D0148C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015243")]
		[Address(RVA = "0x2D014E4", Offset = "0x2D014E4", VA = "0x2D014E4")]
		set
		{
		}
	}

	[Token(Token = "0x17001650")]
	public SceneEditSlotInfo PreviewSlotInfo
	{
		[Token(Token = "0x6015244")]
		[Address(RVA = "0x2D01544", Offset = "0x2D01544", VA = "0x2D01544")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015245")]
		[Address(RVA = "0x2D0159C", Offset = "0x2D0159C", VA = "0x2D0159C")]
		set
		{
		}
	}

	[Token(Token = "0x17001651")]
	public EOpenWorkshopDetailFrom WorkshopDetailWndFrom
	{
		[Token(Token = "0x6015246")]
		[Address(RVA = "0x2D015FC", Offset = "0x2D015FC", VA = "0x2D015FC")]
		get
		{
			return default(EOpenWorkshopDetailFrom);
		}
		[Token(Token = "0x6015247")]
		[Address(RVA = "0x2D01654", Offset = "0x2D01654", VA = "0x2D01654")]
		set
		{
		}
	}

	[Token(Token = "0x17001652")]
	public int WorkshopDetailWndTab
	{
		[Token(Token = "0x6015248")]
		[Address(RVA = "0x2D016B4", Offset = "0x2D016B4", VA = "0x2D016B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6015249")]
		[Address(RVA = "0x2D0170C", Offset = "0x2D0170C", VA = "0x2D0170C")]
		set
		{
		}
	}

	[Token(Token = "0x17001653")]
	public bool IsClipboardCodeValid
	{
		[Token(Token = "0x601524B")]
		[Address(RVA = "0x2D01808", Offset = "0x2D01808", VA = "0x2D01808")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001654")]
	public SceneEditSlotInfo WorkshopCodeInfoForClipboard
	{
		[Token(Token = "0x601524C")]
		[Address(RVA = "0x2D01860", Offset = "0x2D01860", VA = "0x2D01860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001655")]
	public int MyMaxCost
	{
		[Token(Token = "0x60152C6")]
		[Address(RVA = "0x2D1614C", Offset = "0x2D1614C", VA = "0x2D1614C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001656")]
	public List<UGCRemarkRuleData> RemarkRuleDataList
	{
		[Token(Token = "0x60152E6")]
		[Address(RVA = "0x2D1AC24", Offset = "0x2D1AC24", VA = "0x2D1AC24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001657")]
	public CreatorFeedBackData LastSaveCFData
	{
		[Token(Token = "0x60152E7")]
		[Address(RVA = "0x2D1AE90", Offset = "0x2D1AE90", VA = "0x2D1AE90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6015230")]
	[Address(RVA = "0x2D003CC", Offset = "0x2D003CC", VA = "0x2D003CC")]
	public UIModelSceneEdit()
	{
	}

	[Token(Token = "0x601523B")]
	[Address(RVA = "0x2D00C68", Offset = "0x2D00C68", VA = "0x2D00C68")]
	public void AddSaveCount()
	{
	}

	[Token(Token = "0x601523C")]
	[Address(RVA = "0x2D00CCC", Offset = "0x2D00CCC", VA = "0x2D00CCC")]
	public void AddErrorSummary(Dictionary<uint, uint> summary)
	{
	}

	[Token(Token = "0x601523D")]
	[Address(RVA = "0x2D01048", Offset = "0x2D01048", VA = "0x2D01048")]
	private void ClearLogEventData()
	{
	}

	[Token(Token = "0x601523E")]
	[Address(RVA = "0x2D01110", Offset = "0x2D01110", VA = "0x2D01110")]
	public void OnPlayerEnterFreeEdit(bool enter)
	{
	}

	[Token(Token = "0x601523F")]
	[Address(RVA = "0x2D01254", Offset = "0x2D01254", VA = "0x2D01254")]
	public void LogEventPlayerChangeEditType()
	{
	}

	[Token(Token = "0x6015240")]
	[Address(RVA = "0x2D012B8", Offset = "0x2D012B8", VA = "0x2D012B8")]
	public void OnPlayerHideItemList()
	{
	}

	[Token(Token = "0x6015241")]
	[Address(RVA = "0x2D01390", Offset = "0x2D01390", VA = "0x2D01390")]
	public void OnPlayerShowItemList()
	{
	}

	[Token(Token = "0x601524A")]
	[Address(RVA = "0x2D0176C", Offset = "0x2D0176C", VA = "0x2D0176C")]
	public void SetEnterEditReason(EEnterEditFrom enterEditFrom, EOpenWorkshopDetailFrom detailFrom, int wndTab, [Optional] SceneEditSlotInfo previewSlotInfo)
	{
	}

	[Token(Token = "0x601524D")]
	[Address(RVA = "0x2D018B8", Offset = "0x2D018B8", VA = "0x2D018B8")]
	public bool EnterSceneEditInPreview(SceneEditSlotInfo slotInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x601524E")]
	[Address(RVA = "0x2D01E30", Offset = "0x2D01E30", VA = "0x2D01E30")]
	public bool EnterSceneEditWithMySlot(uint slotID, uint mapID, bool download, bool reEnterEdit = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601524F")]
	[Address(RVA = "0x2D02210", Offset = "0x2D02210", VA = "0x2D02210")]
	public bool EnterSceneEditWithMySlot(SceneEditSlotInfo slotInfo, bool download)
	{
		return default(bool);
	}

	[Token(Token = "0x6015250")]
	[Address(RVA = "0x2D022CC", Offset = "0x2D022CC", VA = "0x2D022CC")]
	public bool EnterSceneEditWithCreateNew(uint id, uint map, uint mode, uint template)
	{
		return default(bool);
	}

	[Token(Token = "0x6015251")]
	[Address(RVA = "0x2D01B50", Offset = "0x2D01B50", VA = "0x2D01B50")]
	private void OnEnterResetVar()
	{
	}

	[Token(Token = "0x6015252")]
	[Address(RVA = "0x2D02554", Offset = "0x2D02554", VA = "0x2D02554")]
	public void OnAdjustFloorClicked(bool moveUp, float newHeight)
	{
	}

	[Token(Token = "0x6015253")]
	[Address(RVA = "0x2D020B8", Offset = "0x2D020B8", VA = "0x2D020B8")]
	private void LogEventBegin()
	{
	}

	[Token(Token = "0x6015254")]
	[Address(RVA = "0x2D02600", Offset = "0x2D02600", VA = "0x2D02600")]
	public void ExitSceneEdit()
	{
	}

	[Token(Token = "0x6015255")]
	[Address(RVA = "0x2D03560", Offset = "0x2D03560", VA = "0x2D03560")]
	public void TryOpenNeedUIWhenExitEdit()
	{
	}

	[Token(Token = "0x6015256")]
	[Address(RVA = "0x2D03E68", Offset = "0x2D03E68", VA = "0x2D03E68")]
	public void OnChangePerspective(bool enterOrthographic)
	{
	}

	[Token(Token = "0x6015257")]
	[Address(RVA = "0x2D031BC", Offset = "0x2D031BC", VA = "0x2D031BC")]
	public void OnIntersectionEditModeChanged(bool enterIntersection)
	{
	}

	[Token(Token = "0x6015258")]
	[Address(RVA = "0x2D03FBC", Offset = "0x2D03FBC", VA = "0x2D03FBC")]
	public bool CheckUploadDuringCD()
	{
		return default(bool);
	}

	[Token(Token = "0x6015259")]
	[Address(RVA = "0x2D040FC", Offset = "0x2D040FC", VA = "0x2D040FC")]
	public bool CheckUploadDescDuringCD()
	{
		return default(bool);
	}

	[Token(Token = "0x601525A")]
	[Address(RVA = "0x2D0423C", Offset = "0x2D0423C", VA = "0x2D0423C")]
	public bool CheckUploadSlotNameDuringCD()
	{
		return default(bool);
	}

	[Token(Token = "0x601525B")]
	[Address(RVA = "0x2D0437C", Offset = "0x2D0437C", VA = "0x2D0437C")]
	public bool CheckApplyDuringCD()
	{
		return default(bool);
	}

	[Token(Token = "0x601525C")]
	[Address(RVA = "0x2D044BC", Offset = "0x2D044BC", VA = "0x2D044BC")]
	public bool CheckShareDuringCD()
	{
		return default(bool);
	}

	[Token(Token = "0x601525D")]
	[Address(RVA = "0x2D045FC", Offset = "0x2D045FC", VA = "0x2D045FC")]
	public bool CheckSearchDuringCD()
	{
		return default(bool);
	}

	[Token(Token = "0x601525E")]
	[Address(RVA = "0x2D0473C", Offset = "0x2D0473C", VA = "0x2D0473C")]
	public void HandleReturnToLobby()
	{
	}

	[Token(Token = "0x601525F")]
	[Address(RVA = "0x2D047B8", Offset = "0x2D047B8", VA = "0x2D047B8")]
	public void FillInSceneEditExtraData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto, SceneEditPrefabConfigData configData)
	{
	}

	[Token(Token = "0x6015260")]
	[Address(RVA = "0x2D0499C", Offset = "0x2D0499C", VA = "0x2D0499C")]
	private void FillInSceneEditExtraDataToTeleportDoorData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015261")]
	[Address(RVA = "0x2D04BE0", Offset = "0x2D04BE0", VA = "0x2D04BE0")]
	private void FillInSceneEditExtraDataToBuffGenData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015262")]
	[Address(RVA = "0x2D0596C", Offset = "0x2D0596C", VA = "0x2D0596C")]
	private void FillInSceneEditExtraDataToItemBoxData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015263")]
	[Address(RVA = "0x2D05BB0", Offset = "0x2D05BB0", VA = "0x2D05BB0")]
	private void FillInSceneEditExtraDataToMiniSentryData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015264")]
	[Address(RVA = "0x2D05D9C", Offset = "0x2D05D9C", VA = "0x2D05D9C")]
	private void FillInSceneEditExtraDataToUGCPathData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015265")]
	[Address(RVA = "0x2D05F88", Offset = "0x2D05F88", VA = "0x2D05F88")]
	private void FillInSceneEditExtraDataToUGCBotGeneratorData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015266")]
	[Address(RVA = "0x2D04EAC", Offset = "0x2D04EAC", VA = "0x2D04EAC")]
	private void FillInSceneEditExtraDataToMusicElementData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015267")]
	[Address(RVA = "0x2D050F0", Offset = "0x2D050F0", VA = "0x2D050F0")]
	private void FillInSceneEditExtraDataToMoveObjData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015268")]
	[Address(RVA = "0x2D05334", Offset = "0x2D05334", VA = "0x2D05334")]
	private void FillInSceneEditExtraDataToScaleItemData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x6015269")]
	[Address(RVA = "0x2D056A0", Offset = "0x2D056A0", VA = "0x2D056A0")]
	private void FillInSceneEditExtraDataToTriggerData(FSceneEditObjectData objData, MPIEIPBMHNN attrProto)
	{
	}

	[Token(Token = "0x601526A")]
	[Address(RVA = "0x2D06174", Offset = "0x2D06174", VA = "0x2D06174")]
	public void BuildProtoDataFromObject(float mapGridWidth, SceneEditObjectBase obj, JKJFCPBIKGJ exportedEntityData, MPIEIPBMHNN exportedEntityAttriData)
	{
	}

	[Token(Token = "0x601526B")]
	[Address(RVA = "0x2D06A60", Offset = "0x2D06A60", VA = "0x2D06A60")]
	public void BuildTeleportAttributeProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x601526C")]
	[Address(RVA = "0x2D06C88", Offset = "0x2D06C88", VA = "0x2D06C88")]
	public void BuildMusicElementAttributeProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x601526D")]
	[Address(RVA = "0x2D06E9C", Offset = "0x2D06E9C", VA = "0x2D06E9C")]
	public void BuildBuffGenAttributeProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x601526E")]
	[Address(RVA = "0x2D070F4", Offset = "0x2D070F4", VA = "0x2D070F4")]
	public void BuildItemBoxAttributeProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x601526F")]
	[Address(RVA = "0x2D07308", Offset = "0x2D07308", VA = "0x2D07308")]
	public void BuildMoveObjectAttributeProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x6015270")]
	[Address(RVA = "0x2D07510", Offset = "0x2D07510", VA = "0x2D07510")]
	public void BuildScaleItemAttributeProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x6015271")]
	[Address(RVA = "0x2D077BC", Offset = "0x2D077BC", VA = "0x2D077BC")]
	public void BuildTriggerAttributeProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x6015272")]
	[Address(RVA = "0x2D079F0", Offset = "0x2D079F0", VA = "0x2D079F0")]
	public void BuildMiniSentryAttributeProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x6015273")]
	[Address(RVA = "0x2D07D5C", Offset = "0x2D07D5C", VA = "0x2D07D5C")]
	public void BuildCustomPathProtoBuff(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x6015274")]
	[Address(RVA = "0x2D08B80", Offset = "0x2D08B80", VA = "0x2D08B80")]
	public void BuildMapIconProtoDataFromObject(SceneEditItemIconInfo info, SceneEditObjectBase obj)
	{
	}

	[Token(Token = "0x6015275")]
	[Address(RVA = "0x2D08170", Offset = "0x2D08170", VA = "0x2D08170")]
	public void BuildBigToyBallProtoDataFromObject(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x6015276")]
	[Address(RVA = "0x2D083C4", Offset = "0x2D083C4", VA = "0x2D083C4")]
	public void BuildBotGeneratorProtoDataFromObject(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x6015277")]
	[Address(RVA = "0x2D08AA4", Offset = "0x2D08AA4", VA = "0x2D08AA4")]
	public void BuildResetableProtoDataFromObject(SceneEditObjectBase obj, MPIEIPBMHNN attriProto)
	{
	}

	[Token(Token = "0x6015278")]
	[Address(RVA = "0x2D08F68", Offset = "0x2D08F68", VA = "0x2D08F68")]
	public EditorMiscData BuildMiscDataFromSceneEditObjects()
	{
		return null;
	}

	[Token(Token = "0x6015279")]
	[Address(RVA = "0x2D092AC", Offset = "0x2D092AC", VA = "0x2D092AC")]
	public SceneEditItemIconInfo GetIconItemDataFromBytes(byte[] settings)
	{
		return null;
	}

	[Token(Token = "0x601527A")]
	[Address(RVA = "0x2D094CC", Offset = "0x2D094CC", VA = "0x2D094CC")]
	public bool HasThisCodeSubscribed(string code)
	{
		return default(bool);
	}

	[Token(Token = "0x601527B")]
	[Address(RVA = "0x2D0967C", Offset = "0x2D0967C", VA = "0x2D0967C")]
	public bool IsThisCodeCanBeSubscribed(string code)
	{
		return default(bool);
	}

	[Token(Token = "0x601527C")]
	[Address(RVA = "0x2D098AC", Offset = "0x2D098AC", VA = "0x2D098AC")]
	public bool CanBeUpdated(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601527D")]
	[Address(RVA = "0x2D09A98", Offset = "0x2D09A98", VA = "0x2D09A98")]
	public ulong CalculateDefaultResCnt(ulong resCnt, ulong preCost)
	{
		return default(ulong);
	}

	[Token(Token = "0x601527E")]
	[Address(RVA = "0x2D03310", Offset = "0x2D03310", VA = "0x2D03310")]
	public SceneEditSlotInfo GetSceneEditSlotInfoBySlotTypeAndID(uint slotType, uint slotID)
	{
		return null;
	}

	[Token(Token = "0x601527F")]
	[Address(RVA = "0x2D09B50", Offset = "0x2D09B50", VA = "0x2D09B50")]
	public List<WorkshopHotInfo> GetHotWorkshopInfoList()
	{
		return null;
	}

	[Token(Token = "0x6015280")]
	[Address(RVA = "0x2D09BA8", Offset = "0x2D09BA8", VA = "0x2D09BA8")]
	public List<WorkshopEditorChoiceDesc> GetWorkshopEditorChoiceList()
	{
		return null;
	}

	[Token(Token = "0x6015281")]
	[Address(RVA = "0x2D09C00", Offset = "0x2D09C00", VA = "0x2D09C00")]
	public bool IsHotWorkshopMap(SceneEditSlotInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6015282")]
	[Address(RVA = "0x2D09CE0", Offset = "0x2D09CE0", VA = "0x2D09CE0")]
	public bool GetWorkshopPictureURL(string workshopCode, out string result)
	{
		return default(bool);
	}

	[Token(Token = "0x6015283")]
	[Address(RVA = "0x2D09E44", Offset = "0x2D09E44", VA = "0x2D09E44")]
	private byte[] GetWorkShopBitMapBytes(int width, int[,] arr)
	{
		return null;
	}

	[Token(Token = "0x6015284")]
	[Address(RVA = "0x2D0A040", Offset = "0x2D0A040", VA = "0x2D0A040")]
	public int[,] GetWorkShopBitMapArr(int width, byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6015285")]
	[Address(RVA = "0x2D0A280", Offset = "0x2D0A280", VA = "0x2D0A280")]
	public WorkshopShowMapIconData GetWorkShopMapShowIconData(uint itemid)
	{
		return null;
	}

	[Token(Token = "0x6015286")]
	[Address(RVA = "0x2D0A618", Offset = "0x2D0A618", VA = "0x2D0A618")]
	public List<SceneEditSlotInfo> GetSlotListByType(EWorkshop.SlotType type)
	{
		return null;
	}

	[Token(Token = "0x6015287")]
	[Address(RVA = "0x2D0A6A8", Offset = "0x2D0A6A8", VA = "0x2D0A6A8")]
	public SceneEditSlotInfo GetLocalSaveBySlotId(uint slotId)
	{
		return null;
	}

	[Token(Token = "0x6015288")]
	[Address(RVA = "0x2D0A7EC", Offset = "0x2D0A7EC", VA = "0x2D0A7EC")]
	public SceneEditSlotInfo GetLatestSceneEditSlotInfo()
	{
		return null;
	}

	[Token(Token = "0x6015289")]
	[Address(RVA = "0x2D0A844", Offset = "0x2D0A844", VA = "0x2D0A844")]
	public uint GetLatestSelectedSlotID()
	{
		return default(uint);
	}

	[Token(Token = "0x601528A")]
	[Address(RVA = "0x2D0A89C", Offset = "0x2D0A89C", VA = "0x2D0A89C")]
	public void SetLatestSelectedSlotID(uint id)
	{
	}

	[Token(Token = "0x601528B")]
	[Address(RVA = "0x2D0A8FC", Offset = "0x2D0A8FC", VA = "0x2D0A8FC")]
	public bool PopulateSlotInfoToSceneEditGame(SceneEditSlotInfo slotInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x601528C")]
	[Address(RVA = "0x2D0AA54", Offset = "0x2D0AA54", VA = "0x2D0AA54", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601528D")]
	[Address(RVA = "0x2D0ACD4", Offset = "0x2D0ACD4", VA = "0x2D0ACD4", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601528E")]
	[Address(RVA = "0x2D0ADA0", Offset = "0x2D0ADA0", VA = "0x2D0ADA0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601528F")]
	[Address(RVA = "0x2D0ADF8", Offset = "0x2D0ADF8", VA = "0x2D0ADF8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015290")]
	[Address(RVA = "0x2D0B0D4", Offset = "0x2D0B0D4", VA = "0x2D0B0D4")]
	private void LoadLocalSaves()
	{
	}

	[Token(Token = "0x6015291")]
	[Address(RVA = "0x2D0B434", Offset = "0x2D0B434", VA = "0x2D0B434")]
	private void CheckAndConvertPreviousLocalSave(uint slotId)
	{
	}

	[Token(Token = "0x6015292")]
	[Address(RVA = "0x2D0B860", Offset = "0x2D0B860", VA = "0x2D0B860")]
	private bool CheckPreviousLocalSaveValid(SceneEditSlotInfo slotInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6015293")]
	[Address(RVA = "0x2D0B9B8", Offset = "0x2D0B9B8", VA = "0x2D0B9B8")]
	public void NotifyDataSavedInGame()
	{
	}

	[Token(Token = "0x6015294")]
	[Address(RVA = "0x2D0BA1C", Offset = "0x2D0BA1C", VA = "0x2D0BA1C")]
	public void UpdateAuthorAndLocalSaveSlot(uint slotId)
	{
	}

	[Token(Token = "0x6015295")]
	[Address(RVA = "0x2D0BCBC", Offset = "0x2D0BCBC", VA = "0x2D0BCBC")]
	public void CopyLocalSaveTo(uint srcSlotId, uint destSlotId)
	{
	}

	[Token(Token = "0x6015296")]
	[Address(RVA = "0x2D0C4A4", Offset = "0x2D0C4A4", VA = "0x2D0C4A4")]
	public static byte[] CompressGzip(byte[] inputBytes)
	{
		return null;
	}

	[Token(Token = "0x6015297")]
	[Address(RVA = "0x2D0C8A0", Offset = "0x2D0C8A0", VA = "0x2D0C8A0")]
	public static byte[] UnGZip(byte[] byteArray)
	{
		return null;
	}

	[Token(Token = "0x6015298")]
	[Address(RVA = "0x2D0CD98", Offset = "0x2D0CD98", VA = "0x2D0CD98")]
	private void AppendUGCDefinedStrings(CSGetUploadWorkshopURLReq req, SceneEditSlotInfo slot)
	{
	}

	[Token(Token = "0x6015299")]
	[Address(RVA = "0x2D0D2B8", Offset = "0x2D0D2B8", VA = "0x2D0D2B8")]
	private bool CheckBlockTxtValid(CSGetUploadWorkshopURLReq req)
	{
		return default(bool);
	}

	[Token(Token = "0x601529A")]
	[Address(RVA = "0x2D0D450", Offset = "0x2D0D450", VA = "0x2D0D450")]
	public void RequestUploadWorkshopCDN(SceneEditSlotInfo slot, bool update)
	{
	}

	[Token(Token = "0x601529B")]
	[Address(RVA = "0x2D0DEDC", Offset = "0x2D0DEDC", VA = "0x2D0DEDC")]
	private void OnHandleDirtyWord(uint slotId, EWorkshop.WordFilterType type, string dirtyWord)
	{
	}

	[Token(Token = "0x601529C")]
	[Address(RVA = "0x2D0C248", Offset = "0x2D0C248", VA = "0x2D0C248")]
	public void SetWorkshopDirtyWord(uint slotId, int type, string word)
	{
	}

	[Token(Token = "0x601529D")]
	[Address(RVA = "0x2D0E2D8", Offset = "0x2D0E2D8", VA = "0x2D0E2D8")]
	public int GetWorkshopDirtyWordType(uint slotId)
	{
		return default(int);
	}

	[Token(Token = "0x601529E")]
	[Address(RVA = "0x2D0E498", Offset = "0x2D0E498", VA = "0x2D0E498")]
	public string GetWorkshopDirtyWordValue(uint slotId)
	{
		return null;
	}

	[Token(Token = "0x601529F")]
	[Address(RVA = "0x2D0E670", Offset = "0x2D0E670", VA = "0x2D0E670")]
	public void OnUploadCDNSuccResponse(PGBGOAOCGDC info, CSUploadWorkshopRes res, bool update)
	{
	}

	[Token(Token = "0x60152A0")]
	[Address(RVA = "0x2D0F294", Offset = "0x2D0F294", VA = "0x2D0F294")]
	public void ForceRefreshSlotInfo()
	{
	}

	[Token(Token = "0x60152A1")]
	[Address(RVA = "0x2D0F35C", Offset = "0x2D0F35C", VA = "0x2D0F35C")]
	public void RequestDownloadWorkshopCDN(EWorkshopDownloadType downloadType, EWorkshop.SlotType slotType, uint slotID, uint destId = 0u)
	{
	}

	[Token(Token = "0x60152A2")]
	[Address(RVA = "0x2D0F7B0", Offset = "0x2D0F7B0", VA = "0x2D0F7B0")]
	public void OnDownLoadWorkShopCDNSuccResponse(CSDownloadWorkshopRes data, EWorkshopDownloadType downloadType, EWorkshop.SlotType slotType, uint slotID, uint destID, byte[] cdnProjectBytes, byte[] cdnRuntimeBytes)
	{
	}

	[Token(Token = "0x60152A3")]
	[Address(RVA = "0x2D0F90C", Offset = "0x2D0F90C", VA = "0x2D0F90C")]
	private void HandleDownloadInGame(EWorkshop.SlotType slotType, uint slotID, byte[] downloadedProjectDataBytes)
	{
	}

	[Token(Token = "0x60152A4")]
	[Address(RVA = "0x2D0FF68", Offset = "0x2D0FF68", VA = "0x2D0FF68")]
	private void HandleDownloadLobbySaveAs(EWorkshop.SlotType slotType, uint srcId, uint destId, byte[] projectBytes, byte[] runtimeBytes)
	{
	}

	[Token(Token = "0x60152A5")]
	[Address(RVA = "0x2D10D04", Offset = "0x2D10D04", VA = "0x2D10D04")]
	public void RequestUploadDescInfo(SceneEditSlotInfo info, string desc, string name)
	{
	}

	[Token(Token = "0x60152A6")]
	[Address(RVA = "0x2D11960", Offset = "0x2D11960", VA = "0x2D11960")]
	private void ProcessLocalSaveOnNameChange(SceneEditSlotInfo info, string desc, string name)
	{
	}

	[Token(Token = "0x60152A7")]
	[Address(RVA = "0x2D10A64", Offset = "0x2D10A64", VA = "0x2D10A64")]
	private void ProcessLocalSaveOnDel(uint slotId)
	{
	}

	[Token(Token = "0x60152A8")]
	[Address(RVA = "0x2D11E2C", Offset = "0x2D11E2C", VA = "0x2D11E2C")]
	public void RequestSlotInfo(bool force = false)
	{
	}

	[Token(Token = "0x60152A9")]
	[Address(RVA = "0x2D1218C", Offset = "0x2D1218C", VA = "0x2D1218C")]
	public uint GetfFreeRoomCardCount()
	{
		return default(uint);
	}

	[Token(Token = "0x60152AA")]
	[Address(RVA = "0x2D121F8", Offset = "0x2D121F8", VA = "0x2D121F8")]
	public bool IsFreeRoomCardRefresh()
	{
		return default(bool);
	}

	[Token(Token = "0x60152AB")]
	[Address(RVA = "0x2D12278", Offset = "0x2D12278", VA = "0x2D12278")]
	public void UpdateWorkShopRoomCard(uint freeNum, bool refresh)
	{
	}

	[Token(Token = "0x60152AC")]
	[Address(RVA = "0x2D123C0", Offset = "0x2D123C0", VA = "0x2D123C0")]
	public void RequestSubscriptionSlotInfo()
	{
	}

	[Token(Token = "0x60152AD")]
	[Address(RVA = "0x2D1263C", Offset = "0x2D1263C", VA = "0x2D1263C")]
	public void RequestUnlock(uint slotId, EWorkshop.UnlockSlotCostType costType)
	{
	}

	[Token(Token = "0x60152AE")]
	[Address(RVA = "0x2D128E0", Offset = "0x2D128E0", VA = "0x2D128E0")]
	public void PredownloadCreateCDN()
	{
	}

	[Token(Token = "0x60152AF")]
	[Address(RVA = "0x2D12C9C", Offset = "0x2D12C9C", VA = "0x2D12C9C")]
	public List<UGCCustomModeTemplateRuleData> GetUGCCustomModeTemplateRuleDataList()
	{
		return null;
	}

	[Token(Token = "0x60152B0")]
	[Address(RVA = "0x2D12E38", Offset = "0x2D12E38", VA = "0x2D12E38")]
	public void RequestWorkshopCustomModeTemplateRule(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60152B1")]
	[Address(RVA = "0x2D130B0", Offset = "0x2D130B0", VA = "0x2D130B0")]
	public void RequestShare(uint slot)
	{
	}

	[Token(Token = "0x60152B2")]
	[Address(RVA = "0x2D13378", Offset = "0x2D13378", VA = "0x2D13378")]
	public void RequestDelSubscription(uint id)
	{
	}

	[Token(Token = "0x60152B3")]
	[Address(RVA = "0x2D13824", Offset = "0x2D13824", VA = "0x2D13824")]
	public void RequestDelAuthor(uint id, EWorkshopDelType type)
	{
	}

	[Token(Token = "0x60152B4")]
	[Address(RVA = "0x2D133F8", Offset = "0x2D133F8", VA = "0x2D133F8")]
	private void RequestDel(EWorkshop.SlotType type, uint id, EWorkshopDelType delType)
	{
	}

	[Token(Token = "0x60152B5")]
	[Address(RVA = "0x2D13A2C", Offset = "0x2D13A2C", VA = "0x2D13A2C")]
	public uint GetNextUnlockSlotID()
	{
		return default(uint);
	}

	[Token(Token = "0x60152B6")]
	[Address(RVA = "0x2D13BF0", Offset = "0x2D13BF0", VA = "0x2D13BF0")]
	public uint GetNextEmptySlotID()
	{
		return default(uint);
	}

	[Token(Token = "0x60152B7")]
	[Address(RVA = "0x2D13DB4", Offset = "0x2D13DB4", VA = "0x2D13DB4")]
	public EQuickSubResult TryRequestQuickSubscribeOrDel(string code, EUGCScene src)
	{
		return default(EQuickSubResult);
	}

	[Token(Token = "0x60152B8")]
	[Address(RVA = "0x2D140A0", Offset = "0x2D140A0", VA = "0x2D140A0")]
	private bool IsValidQuickOp()
	{
		return default(bool);
	}

	[Token(Token = "0x60152B9")]
	[Address(RVA = "0x2D142A8", Offset = "0x2D142A8", VA = "0x2D142A8")]
	public void RequestSubscribe(uint id, string code, EUGCScene src)
	{
	}

	[Token(Token = "0x60152BA")]
	[Address(RVA = "0x2D14628", Offset = "0x2D14628", VA = "0x2D14628")]
	public void ClearCDNCache()
	{
	}

	[Token(Token = "0x60152BB")]
	[Address(RVA = "0x2D14804", Offset = "0x2D14804", VA = "0x2D14804")]
	public void RequestPreview(string previewCode)
	{
	}

	[Token(Token = "0x60152BC")]
	[Address(RVA = "0x2D14B68", Offset = "0x2D14B68", VA = "0x2D14B68")]
	public void OnDownLoadPreivewCDNSuccResponse(CSPreviewWorkshopCodeRes data, string previewCode, byte[] downloadedBytes)
	{
	}

	[Token(Token = "0x60152BD")]
	[Address(RVA = "0x2D1512C", Offset = "0x2D1512C", VA = "0x2D1512C")]
	public bool CheckLastCDNDownloadFailed()
	{
		return default(bool);
	}

	[Token(Token = "0x60152BE")]
	[Address(RVA = "0x2D15190", Offset = "0x2D15190", VA = "0x2D15190")]
	public void OnDownloadFailed(EWorkshopDownloadType downloadType)
	{
	}

	[Token(Token = "0x60152BF")]
	[Address(RVA = "0x2D15278", Offset = "0x2D15278", VA = "0x2D15278")]
	public void OnDownloading()
	{
	}

	[Token(Token = "0x60152C0")]
	[Address(RVA = "0x2D15340", Offset = "0x2D15340", VA = "0x2D15340")]
	public void OnUploadFailed(bool isUpdate)
	{
	}

	[Token(Token = "0x60152C1")]
	[Address(RVA = "0x2D14C74", Offset = "0x2D14C74", VA = "0x2D14C74")]
	private void HandlePreviewInGame(string previewCode, byte[] downloadedProjectDataBytesForPreview)
	{
	}

	[Token(Token = "0x60152C2")]
	[Address(RVA = "0x2D15428", Offset = "0x2D15428", VA = "0x2D15428")]
	public void RequestCheckShareCode(bool isLogin, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60152C3")]
	[Address(RVA = "0x2D15998", Offset = "0x2D15998", VA = "0x2D15998")]
	public void RequestSearch(string code, bool isGMPreview = false)
	{
	}

	[Token(Token = "0x60152C4")]
	[Address(RVA = "0x2D15D38", Offset = "0x2D15D38", VA = "0x2D15D38")]
	public void RequestReport(string code, uint type, EUGCScene src)
	{
	}

	[Token(Token = "0x60152C5")]
	[Address(RVA = "0x2D160F4", Offset = "0x2D160F4", VA = "0x2D160F4")]
	public WorkshopAccountInfo GetMyAccountWorkShopInfo()
	{
		return null;
	}

	[Token(Token = "0x60152C7")]
	[Address(RVA = "0x2D161A4", Offset = "0x2D161A4", VA = "0x2D161A4")]
	private void InitMyMaxCost()
	{
	}

	[Token(Token = "0x60152C8")]
	[Address(RVA = "0x2D163F0", Offset = "0x2D163F0", VA = "0x2D163F0")]
	public void RequestWorkShopPersonalInfo()
	{
	}

	[Token(Token = "0x60152C9")]
	[Address(RVA = "0x2D16720", Offset = "0x2D16720", VA = "0x2D16720")]
	public void CheckLevelCanRewarded()
	{
	}

	[Token(Token = "0x60152CA")]
	[Address(RVA = "0x2D16A98", Offset = "0x2D16A98", VA = "0x2D16A98")]
	private void SendUGCLoginInfo()
	{
	}

	[Token(Token = "0x60152CB")]
	[Address(RVA = "0x2D16BF4", Offset = "0x2D16BF4", VA = "0x2D16BF4")]
	public void RequestRecommendationInfo(bool force = false)
	{
	}

	[Token(Token = "0x60152CC")]
	[Address(RVA = "0x2D16F90", Offset = "0x2D16F90", VA = "0x2D16F90")]
	public void RequestEditorChoiceById(uint id)
	{
	}

	[Token(Token = "0x60152CD")]
	[Address(RVA = "0x2D173F8", Offset = "0x2D173F8", VA = "0x2D173F8")]
	public void RequestLatestInfo()
	{
	}

	[Token(Token = "0x60152CE")]
	[Address(RVA = "0x2D1765C", Offset = "0x2D1765C", VA = "0x2D1765C")]
	public void RequestHistoryInfo()
	{
	}

	[Token(Token = "0x60152CF")]
	[Address(RVA = "0x2D178C0", Offset = "0x2D178C0", VA = "0x2D178C0")]
	public void RequestSelfdomInfo(bool isFirst)
	{
	}

	[Token(Token = "0x60152D0")]
	[Address(RVA = "0x2D17D70", Offset = "0x2D17D70", VA = "0x2D17D70")]
	public bool CheckRefreshSelfdomInfoCD()
	{
		return default(bool);
	}

	[Token(Token = "0x60152D1")]
	[Address(RVA = "0x2D180A0", Offset = "0x2D180A0", VA = "0x2D180A0")]
	public void RequestLikeCode(string code, bool isLike)
	{
	}

	[Token(Token = "0x60152D2")]
	[Address(RVA = "0x2D18448", Offset = "0x2D18448", VA = "0x2D18448")]
	public void RequestCommentCode(SceneEditSlotInfo info, uint[] tags, EUGCScene src)
	{
	}

	[Token(Token = "0x60152D3")]
	[Address(RVA = "0x2D187AC", Offset = "0x2D187AC", VA = "0x2D187AC")]
	public bool IsCommentDuringCD(string code)
	{
		return default(bool);
	}

	[Token(Token = "0x60152D4")]
	[Address(RVA = "0x2D18940", Offset = "0x2D18940", VA = "0x2D18940")]
	private void HandleErrorMsg()
	{
	}

	[Token(Token = "0x60152D5")]
	[Address(RVA = "0x2D0DAB0", Offset = "0x2D0DAB0", VA = "0x2D0DAB0")]
	private void ShowPopTips(string msg, object[] data)
	{
	}

	[Token(Token = "0x60152D6")]
	[Address(RVA = "0x2D01BE8", Offset = "0x2D01BE8", VA = "0x2D01BE8")]
	private void LoadSceneEditGame()
	{
	}

	[Token(Token = "0x60152D7")]
	[Address(RVA = "0x2D18A2C", Offset = "0x2D18A2C", VA = "0x2D18A2C")]
	public NOEMLIPGACF GetWorkshopSettingFromItemMap(Dictionary<int, SceneEditObjectBase> itemMap)
	{
		return null;
	}

	[Token(Token = "0x60152D8")]
	[Address(RVA = "0x2D18A90", Offset = "0x2D18A90", VA = "0x2D18A90")]
	private List<SceneEditObjectBase> CollectAllSceneEditObjects(Dictionary<int, SceneEditObjectBase> itemMap)
	{
		return null;
	}

	[Token(Token = "0x60152D9")]
	[Address(RVA = "0x2D18EDC", Offset = "0x2D18EDC", VA = "0x2D18EDC")]
	public HEAABFEMIDG ExtractMapRuntimeData(float mapGridWidth, Dictionary<int, SceneEditObjectBase> itemMap)
	{
		return null;
	}

	[Token(Token = "0x60152DA")]
	[Address(RVA = "0x2D19224", Offset = "0x2D19224", VA = "0x2D19224")]
	public byte[] ExtractWorkshopBitMap(KEMMDGJBJNO sceneBuilder)
	{
		return null;
	}

	[Token(Token = "0x60152DB")]
	[Address(RVA = "0x2D19344", Offset = "0x2D19344", VA = "0x2D19344")]
	public byte[] ExtractWorkshopIconMap(Dictionary<int, SceneEditObjectBase> itemMap)
	{
		return null;
	}

	[Token(Token = "0x60152DC")]
	[Address(RVA = "0x2D196FC", Offset = "0x2D196FC", VA = "0x2D196FC")]
	public List<uint> ExtractTags()
	{
		return null;
	}

	[Token(Token = "0x60152DD")]
	[Address(RVA = "0x2D19104", Offset = "0x2D19104", VA = "0x2D19104")]
	public FEIGJAGLKLM ExtractModeSetting()
	{
		return null;
	}

	[Token(Token = "0x60152DE")]
	[Address(RVA = "0x2D1981C", Offset = "0x2D1981C", VA = "0x2D1981C")]
	public bool IsSubscriptionSlotLastUpdated(SceneEditSlotInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60152DF")]
	[Address(RVA = "0x2D1997C", Offset = "0x2D1997C", VA = "0x2D1997C")]
	public bool IsWorkshopBanned()
	{
		return default(bool);
	}

	[Token(Token = "0x60152E0")]
	[Address(RVA = "0x2D199D4", Offset = "0x2D199D4", VA = "0x2D199D4")]
	public bool IsWorkshopManager()
	{
		return default(bool);
	}

	[Token(Token = "0x60152E1")]
	[Address(RVA = "0x2D03AFC", Offset = "0x2D03AFC", VA = "0x2D03AFC")]
	public UIWorkshopDetailController OpenWorkshopDetailWnd(SceneEditSlotInfo slotInfo, EUGCScene scene, EOpenWorkshopDetailFrom from = EOpenWorkshopDetailFrom.None, UISceneEditUGCCenterController.ETabIndex tabIndex = UISceneEditUGCCenterController.ETabIndex.ETabIndex_Recommendation)
	{
		return null;
	}

	[Token(Token = "0x60152E2")]
	[Address(RVA = "0x2D19A2C", Offset = "0x2D19A2C", VA = "0x2D19A2C")]
	public List<SceneEditSlotInfo> GetCreateRoomSlotInfos(EWorkShopCreateRoomSrc src)
	{
		return null;
	}

	[Token(Token = "0x60152E3")]
	[Address(RVA = "0x2D1A63C", Offset = "0x2D1A63C", VA = "0x2D1A63C")]
	public void SetRoomCreateSrcIndex(EWorkShopCreateRoomSrc src, int index)
	{
	}

	[Token(Token = "0x60152E4")]
	[Address(RVA = "0x2D1A7EC", Offset = "0x2D1A7EC", VA = "0x2D1A7EC")]
	public EWorkShopCreateRoomSrc GetRoomCreateSrc()
	{
		return default(EWorkShopCreateRoomSrc);
	}

	[Token(Token = "0x60152E5")]
	[Address(RVA = "0x2D1AA2C", Offset = "0x2D1AA2C", VA = "0x2D1AA2C")]
	public int GetRoomCreateIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60152E8")]
	[Address(RVA = "0x2D1B044", Offset = "0x2D1B044", VA = "0x2D1B044")]
	public void SaveCreatorData(ulong subscriptionTimes, ulong likedTimes)
	{
	}

	[Token(Token = "0x60152E9")]
	[Address(RVA = "0x2D0F02C", Offset = "0x2D0F02C", VA = "0x2D0F02C")]
	private void SaveLastOpenCFTimeStamp()
	{
	}

	[Token(Token = "0x60152EA")]
	[Address(RVA = "0x2D0F168", Offset = "0x2D0F168", VA = "0x2D0F168")]
	private void DeleteCFLocalData()
	{
	}

	[Token(Token = "0x60152EB")]
	[Address(RVA = "0x2D1B1F4", Offset = "0x2D1B1F4", VA = "0x2D1B1F4")]
	public bool CheckShowCFPopWin()
	{
		return default(bool);
	}

	[Token(Token = "0x60152EC")]
	[Address(RVA = "0x2D0EE8C", Offset = "0x2D0EE8C", VA = "0x2D0EE8C")]
	private int GetAuthorPublishedSlotCount()
	{
		return default(int);
	}

	[Token(Token = "0x60152ED")]
	[Address(RVA = "0x2D1B3C0", Offset = "0x2D1B3C0", VA = "0x2D1B3C0")]
	public UISceneEditCreatorFeedbackPopWndController OpenCreatorFeedBackWnd()
	{
		return null;
	}

	[Token(Token = "0x60152EE")]
	[Address(RVA = "0x2D1B4D0", Offset = "0x2D1B4D0", VA = "0x2D1B4D0")]
	public bool CheckHasOpendUserAgreement()
	{
		return default(bool);
	}

	[Token(Token = "0x60152EF")]
	[Address(RVA = "0x2D1B5C8", Offset = "0x2D1B5C8", VA = "0x2D1B5C8")]
	public void SetHasOpendUserAgreementOpen()
	{
	}

	[Token(Token = "0x60152F0")]
	[Address(RVA = "0x2D1B6BC", Offset = "0x2D1B6BC", VA = "0x2D1B6BC")]
	public bool EnableShowGMVerify()
	{
		return default(bool);
	}

	[Token(Token = "0x60152F2")]
	[Address(RVA = "0x2D1BA80", Offset = "0x2D1BA80", VA = "0x2D1BA80")]
	private void _003CRequestSlotInfo_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152F3")]
	[Address(RVA = "0x2D1D5AC", Offset = "0x2D1D5AC", VA = "0x2D1D5AC")]
	private void _003CRequestSubscriptionSlotInfo_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152F4")]
	[Address(RVA = "0x2D1DC3C", Offset = "0x2D1DC3C", VA = "0x2D1DC3C")]
	private void _003CRequestUnlock_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152F5")]
	[Address(RVA = "0x2D1E094", Offset = "0x2D1E094", VA = "0x2D1E094")]
	private void _003CRequestWorkshopCustomModeTemplateRule_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152F6")]
	[Address(RVA = "0x2D1E1D0", Offset = "0x2D1E1D0", VA = "0x2D1E1D0")]
	private void _003CRequestShare_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152F7")]
	[Address(RVA = "0x2D1E550", Offset = "0x2D1E550", VA = "0x2D1E550")]
	private static bool _003CGetNextUnlockSlotID_003Em__5(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x60152F8")]
	[Address(RVA = "0x2D1E57C", Offset = "0x2D1E57C", VA = "0x2D1E57C")]
	private static bool _003CGetNextEmptySlotID_003Em__6(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x60152F9")]
	[Address(RVA = "0x2D1E5A8", Offset = "0x2D1E5A8", VA = "0x2D1E5A8")]
	private static bool _003CTryRequestQuickSubscribeOrDel_003Em__7(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x60152FA")]
	[Address(RVA = "0x2D1E5D4", Offset = "0x2D1E5D4", VA = "0x2D1E5D4")]
	private void _003CRequestWorkShopPersonalInfo_003Em__8(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152FB")]
	[Address(RVA = "0x2D1E7DC", Offset = "0x2D1E7DC", VA = "0x2D1E7DC")]
	private void _003CRequestRecommendationInfo_003Em__9(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152FC")]
	[Address(RVA = "0x2D1EF0C", Offset = "0x2D1EF0C", VA = "0x2D1EF0C")]
	private void _003CRequestLatestInfo_003Em__A(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152FD")]
	[Address(RVA = "0x2D1F1C4", Offset = "0x2D1F1C4", VA = "0x2D1F1C4")]
	private void _003CRequestHistoryInfo_003Em__B(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152FE")]
	[Address(RVA = "0x2D1F374", Offset = "0x2D1F374", VA = "0x2D1F374")]
	private static void _003CRequestLikeCode_003Em__C(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60152FF")]
	[Address(RVA = "0x2D1F378", Offset = "0x2D1F378", VA = "0x2D1F378")]
	private void _003CRequestCommentCode_003Em__D(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015300")]
	[Address(RVA = "0x2D1F570", Offset = "0x2D1F570", VA = "0x2D1F570")]
	private static int _003CCollectAllSceneEditObjects_003Em__E(SceneEditObjectBase a, SceneEditObjectBase b)
	{
		return default(int);
	}

	[Token(Token = "0x6015301")]
	[Address(RVA = "0x2D1F61C", Offset = "0x2D1F61C", VA = "0x2D1F61C")]
	private static bool _003CGetCreateRoomSlotInfos_003Em__F(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x6015302")]
	[Address(RVA = "0x2D1F648", Offset = "0x2D1F648", VA = "0x2D1F648")]
	private static bool _003CGetCreateRoomSlotInfos_003Em__10(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x6015303")]
	[Address(RVA = "0x2D1F674", Offset = "0x2D1F674", VA = "0x2D1F674")]
	private static bool _003CGetCreateRoomSlotInfos_003Em__11(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x6015304")]
	[Address(RVA = "0x2D1F6A8", Offset = "0x2D1F6A8", VA = "0x2D1F6A8")]
	private static int _003Cget_RemarkRuleDataList_003Em__12(UGCRemarkRuleData a, UGCRemarkRuleData b)
	{
		return default(int);
	}

	[Token(Token = "0x6015305")]
	[Address(RVA = "0x2D1F6E8", Offset = "0x2D1F6E8", VA = "0x2D1F6E8")]
	private static bool _003CRequestSlotInfo_003Em__13(SceneEditSlotInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x6015306")]
	[Address(RVA = "0x2D1F718", Offset = "0x2D1F718", VA = "0x2D1F718")]
	private static int _003CRequestSlotInfo_003Em__14(SceneEditSlotInfo a, SceneEditSlotInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6015307")]
	[Address(RVA = "0x2D1F760", Offset = "0x2D1F760", VA = "0x2D1F760")]
	private static int _003CRequestSlotInfo_003Em__15(SceneEditSlotInfo a, SceneEditSlotInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6015308")]
	[Address(RVA = "0x2D1F7A8", Offset = "0x2D1F7A8", VA = "0x2D1F7A8")]
	private static int _003CRequestSlotInfo_003Em__16(SceneEditSlotInfo a, SceneEditSlotInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6015309")]
	[Address(RVA = "0x2D1F7F0", Offset = "0x2D1F7F0", VA = "0x2D1F7F0")]
	private static int _003CRequestSubscriptionSlotInfo_003Em__17(SceneEditSlotInfo a, SceneEditSlotInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x601530A")]
	[Address(RVA = "0x2D1F838", Offset = "0x2D1F838", VA = "0x2D1F838")]
	private static int _003CRequestRecommendationInfo_003Em__18(WorkshopHotInfo a, WorkshopHotInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x601530B")]
	[Address(RVA = "0x2D1F880", Offset = "0x2D1F880", VA = "0x2D1F880")]
	private static int _003CRequestRecommendationInfo_003Em__19(WorkshopEditorChoiceDesc a, WorkshopEditorChoiceDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x601530C")]
	[Address(RVA = "0x2D1F8C8", Offset = "0x2D1F8C8", VA = "0x2D1F8C8")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x601530D")]
	[Address(RVA = "0x2D1F8D0", Offset = "0x2D1F8D0", VA = "0x2D1F8D0")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	[Token(Token = "0x601530E")]
	[Address(RVA = "0x2D1F8D8", Offset = "0x2D1F8D8", VA = "0x2D1F8D8")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
