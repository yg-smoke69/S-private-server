using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EA8")]
public class UIModelAnnouncement : UIBaseModel
{
	[Token(Token = "0x2002EA9")]
	public enum DataState
	{
		[Token(Token = "0x4011D02")]
		None,
		[Token(Token = "0x4011D03")]
		Fetching,
		[Token(Token = "0x4011D04")]
		Fetched
	}

	[Token(Token = "0x4011CF8")]
	public const uint PropID_AnnounceRetOK = 2u;

	[Token(Token = "0x4011CF9")]
	public const uint PropID_AnnounceRetFailed = 4u;

	[Token(Token = "0x4011CFA")]
	private const string ANNOUNCEMENT_READED_FORMAT = "Announcement{0}";

	[Token(Token = "0x4011CFB")]
	[FieldOffset(Offset = "0xC")]
	public bool IsAnnouncementShowed;

	[Token(Token = "0x4011CFC")]
	[FieldOffset(Offset = "0x10")]
	private DataState _003CCurrentDataState_003Ek__BackingField;

	[Token(Token = "0x4011CFD")]
	[FieldOffset(Offset = "0x14")]
	private List<AnnoucementInfo> m_AnnouncementDataList;

	[Token(Token = "0x4011CFE")]
	[FieldOffset(Offset = "0x18")]
	private LoginRes m_LastLoginResCache;

	[Token(Token = "0x4011CFF")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AnnoucementInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011D00")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<AnnoucementInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x1700144C")]
	public DataState CurrentDataState
	{
		[Token(Token = "0x6013805")]
		[Address(RVA = "0x30AECB8", Offset = "0x30AECB8", VA = "0x30AECB8")]
		get
		{
			return default(DataState);
		}
		[Token(Token = "0x6013806")]
		[Address(RVA = "0x30AECC0", Offset = "0x30AECC0", VA = "0x30AECC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700144D")]
	public List<AnnoucementInfo> AnnouncementDataList
	{
		[Token(Token = "0x6013807")]
		[Address(RVA = "0x30AECC8", Offset = "0x30AECC8", VA = "0x30AECC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6013803")]
	[Address(RVA = "0x30AEBA8", Offset = "0x30AEBA8", VA = "0x30AEBA8")]
	public UIModelAnnouncement()
	{
	}

	[Token(Token = "0x6013804")]
	[Address(RVA = "0x30AEC60", Offset = "0x30AEC60", VA = "0x30AEC60", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013808")]
	[Address(RVA = "0x30AED20", Offset = "0x30AED20", VA = "0x30AED20", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013809")]
	[Address(RVA = "0x30AEE44", Offset = "0x30AEE44", VA = "0x30AEE44", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x601380A")]
	[Address(RVA = "0x30AEFF0", Offset = "0x30AEFF0", VA = "0x30AEFF0")]
	public HttpRequest RequestAnnouncementSplashActivityData(float timeout = 0f, bool forceUpdate = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
		return null;
	}

	[Token(Token = "0x601380B")]
	[Address(RVA = "0x30AF400", Offset = "0x30AF400", VA = "0x30AF400")]
	private void UpdateTipsNum()
	{
	}

	[Token(Token = "0x601380C")]
	[Address(RVA = "0x30AF5B0", Offset = "0x30AF5B0", VA = "0x30AF5B0")]
	public bool IsUnreadAnnouncement(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601380D")]
	[Address(RVA = "0x30AF704", Offset = "0x30AF704", VA = "0x30AF704")]
	public void SetReadAnnouncement(uint id)
	{
	}

	[Token(Token = "0x601380E")]
	[Address(RVA = "0x30AF860", Offset = "0x30AF860", VA = "0x30AF860")]
	public void TestAnnouncementData(List<AnnoucementInfo> announcementData)
	{
	}

	[Token(Token = "0x601380F")]
	[Address(RVA = "0x30AF9B4", Offset = "0x30AF9B4", VA = "0x30AF9B4")]
	public bool CheckCanShowByQuality(EAnnouncement.PhoneQuality quality)
	{
		return default(bool);
	}

	[Token(Token = "0x6013810")]
	[Address(RVA = "0x30AFBB0", Offset = "0x30AFBB0", VA = "0x30AFBB0")]
	public bool CheckCanShowByAccountID(string lastNums)
	{
		return default(bool);
	}

	[Token(Token = "0x6013811")]
	[Address(RVA = "0x30AFEE0", Offset = "0x30AFEE0", VA = "0x30AFEE0")]
	private void _003CRequestAnnouncementSplashActivityData_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013812")]
	[Address(RVA = "0x30B0538", Offset = "0x30B0538", VA = "0x30B0538")]
	private static int _003CTestAnnouncementData_003Em__1(AnnoucementInfo a, AnnoucementInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6013813")]
	[Address(RVA = "0x30B05A8", Offset = "0x30B05A8", VA = "0x30B05A8")]
	private static int _003CRequestAnnouncementSplashActivityData_003Em__2(AnnoucementInfo a, AnnoucementInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6013814")]
	[Address(RVA = "0x30B0618", Offset = "0x30B0618", VA = "0x30B0618")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x6013815")]
	[Address(RVA = "0x30B0620", Offset = "0x30B0620", VA = "0x30B0620")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
