using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200311C")]
public class UIModelMail : UIBaseModel
{
	[Token(Token = "0x200311D")]
	private sealed class _003CRequestReadMail_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012ABD")]
		[FieldOffset(Offset = "0x8")]
		internal EMail.Status status;

		[Token(Token = "0x4012ABE")]
		[FieldOffset(Offset = "0xC")]
		internal List<MailInfo> mails;

		[Token(Token = "0x4012ABF")]
		[FieldOffset(Offset = "0x10")]
		internal bool isBatchOp;

		[Token(Token = "0x4012AC0")]
		[FieldOffset(Offset = "0x11")]
		internal bool isFriendGift;

		[Token(Token = "0x4012AC1")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelMail _0024this;

		[Token(Token = "0x601497F")]
		[Address(RVA = "0x2FC7AFC", Offset = "0x2FC7AFC", VA = "0x2FC7AFC")]
		public _003CRequestReadMail_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014980")]
		[Address(RVA = "0x2FC7B04", Offset = "0x2FC7B04", VA = "0x2FC7B04")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014981")]
		[Address(RVA = "0x2FC82B0", Offset = "0x2FC82B0", VA = "0x2FC82B0")]
		internal void _003C_003Em__1(MailInfo a)
		{
		}

		[Token(Token = "0x6014982")]
		[Address(RVA = "0x2FC8330", Offset = "0x2FC8330", VA = "0x2FC8330")]
		internal void _003C_003Em__2(MailInfo a)
		{
		}
	}

	[Token(Token = "0x200311E")]
	private sealed class _003CRequestReadReportMail_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012AC2")]
		[FieldOffset(Offset = "0x8")]
		internal EMail.Status status;

		[Token(Token = "0x4012AC3")]
		[FieldOffset(Offset = "0xC")]
		internal List<ReportMailInfo> mails;

		[Token(Token = "0x4012AC4")]
		[FieldOffset(Offset = "0x10")]
		internal bool isBatchOp;

		[Token(Token = "0x4012AC5")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelMail _0024this;

		[Token(Token = "0x6014983")]
		[Address(RVA = "0x2FC840C", Offset = "0x2FC840C", VA = "0x2FC840C")]
		public _003CRequestReadReportMail_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014984")]
		[Address(RVA = "0x2FC8414", Offset = "0x2FC8414", VA = "0x2FC8414")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014985")]
		[Address(RVA = "0x2FC88A4", Offset = "0x2FC88A4", VA = "0x2FC88A4")]
		internal void _003C_003Em__1(ReportMailInfo a)
		{
		}

		[Token(Token = "0x6014986")]
		[Address(RVA = "0x2FC8924", Offset = "0x2FC8924", VA = "0x2FC8924")]
		internal void _003C_003Em__2(ReportMailInfo a)
		{
		}
	}

	[Token(Token = "0x4012A98")]
	private const string READ_MAIL_KEY = "READ_MAIL";

	[Token(Token = "0x4012A99")]
	private const string READ_REPORT_MAIL_KEY = "READ_REPORT_MAIL";

	[Token(Token = "0x4012A9A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int MAX_MAIL_SHOW;

	[Token(Token = "0x4012A9B")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int MAIL_EXPIRE_DAYS;

	[Token(Token = "0x4012A9C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int MAX_REPORT_MAIL_SHOW;

	[Token(Token = "0x4012A9D")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int MAIL_REPORT_EXPIRE_DAYS;

	[Token(Token = "0x4012A9E")]
	public const uint PropID_GetMailRetOK = 2u;

	[Token(Token = "0x4012A9F")]
	public const uint PropID_GetMailRetFail = 4u;

	[Token(Token = "0x4012AA0")]
	public const uint PropID_ReadMailRetOK = 8u;

	[Token(Token = "0x4012AA1")]
	public const uint PropID_ReadMailRetFail = 16u;

	[Token(Token = "0x4012AA2")]
	public const uint PropID_GetReportMailRetOK = 32u;

	[Token(Token = "0x4012AA3")]
	public const uint PropID_GetReportMailRetFail = 64u;

	[Token(Token = "0x4012AA4")]
	public const uint PropID_ReadReportMailRetOK = 128u;

	[Token(Token = "0x4012AA5")]
	public const uint PropID_ReadReportMailRetFail = 256u;

	[Token(Token = "0x4012AA6")]
	[FieldOffset(Offset = "0xC")]
	private bool _003CHasNewMail_003Ek__BackingField;

	[Token(Token = "0x4012AA7")]
	[FieldOffset(Offset = "0xD")]
	private bool _003CHasNewReportMail_003Ek__BackingField;

	[Token(Token = "0x4012AA8")]
	[FieldOffset(Offset = "0x10")]
	private int _003CNewMailCount_003Ek__BackingField;

	[Token(Token = "0x4012AA9")]
	[FieldOffset(Offset = "0x14")]
	private int _003CNewReportMailCount_003Ek__BackingField;

	[Token(Token = "0x4012AAA")]
	[FieldOffset(Offset = "0x18")]
	private string m_ReportMatchTime;

	[Token(Token = "0x4012AAB")]
	[FieldOffset(Offset = "0x1C")]
	private string m_ReportMainReasons;

	[Token(Token = "0x4012AAC")]
	[FieldOffset(Offset = "0x20")]
	private List<uint> m_ReportTypeLists;

	[Token(Token = "0x4012AAD")]
	[FieldOffset(Offset = "0x24")]
	private List<MailInfo> m_CachedMailInfoList;

	[Token(Token = "0x4012AAE")]
	[FieldOffset(Offset = "0x28")]
	private List<MailInfo> m_ShowMailInfoList;

	[Token(Token = "0x4012AAF")]
	[FieldOffset(Offset = "0x2C")]
	private List<MailInfo> m_NoReciveGiftMailList;

	[Token(Token = "0x4012AB0")]
	[FieldOffset(Offset = "0x30")]
	private List<ReportMailInfo> m_CachedReportMailInfoList;

	[Token(Token = "0x4012AB1")]
	[FieldOffset(Offset = "0x34")]
	private List<ReportMailInfo> m_ShowReportMailInfoList;

	[Token(Token = "0x4012AB2")]
	[FieldOffset(Offset = "0x38")]
	private HashSet<string> m_ReadMailIDs;

	[Token(Token = "0x4012AB3")]
	[FieldOffset(Offset = "0x3C")]
	private HashSet<string> m_CurrentMailIDs;

	[Token(Token = "0x4012AB4")]
	[FieldOffset(Offset = "0x40")]
	private HashSet<string> m_ReadReportMailIDs;

	[Token(Token = "0x4012AB5")]
	[FieldOffset(Offset = "0x44")]
	private HashSet<string> m_CurrentReportMailIDs;

	[Token(Token = "0x4012AB6")]
	[FieldOffset(Offset = "0x10")]
	private static Func<MailInfo, ulong> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012AB7")]
	[FieldOffset(Offset = "0x14")]
	private static Func<ReportMailInfo, ulong> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012AB8")]
	[FieldOffset(Offset = "0x18")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4012AB9")]
	[FieldOffset(Offset = "0x1C")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4012ABA")]
	[FieldOffset(Offset = "0x20")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4012ABB")]
	[FieldOffset(Offset = "0x24")]
	private static Comparison<MailInfo> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4012ABC")]
	[FieldOffset(Offset = "0x28")]
	private static Comparison<ReportMailInfo> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x1700156E")]
	public bool HasNewMail
	{
		[Token(Token = "0x6014944")]
		[Address(RVA = "0x1B1EAE4", Offset = "0x1B1EAE4", VA = "0x1B1EAE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014945")]
		[Address(RVA = "0x1B1EAEC", Offset = "0x1B1EAEC", VA = "0x1B1EAEC")]
		set
		{
		}
	}

	[Token(Token = "0x1700156F")]
	public bool HasNewReportMail
	{
		[Token(Token = "0x6014946")]
		[Address(RVA = "0x1B1EAF4", Offset = "0x1B1EAF4", VA = "0x1B1EAF4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014947")]
		[Address(RVA = "0x1B1EAFC", Offset = "0x1B1EAFC", VA = "0x1B1EAFC")]
		set
		{
		}
	}

	[Token(Token = "0x17001570")]
	public int NewMailCount
	{
		[Token(Token = "0x6014948")]
		[Address(RVA = "0x1B1EB04", Offset = "0x1B1EB04", VA = "0x1B1EB04")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014949")]
		[Address(RVA = "0x1B1EB0C", Offset = "0x1B1EB0C", VA = "0x1B1EB0C")]
		set
		{
		}
	}

	[Token(Token = "0x17001571")]
	public int NewReportMailCount
	{
		[Token(Token = "0x601494A")]
		[Address(RVA = "0x1B1EB14", Offset = "0x1B1EB14", VA = "0x1B1EB14")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601494B")]
		[Address(RVA = "0x1B1EB1C", Offset = "0x1B1EB1C", VA = "0x1B1EB1C")]
		set
		{
		}
	}

	[Token(Token = "0x6014942")]
	[Address(RVA = "0x1B1E8A8", Offset = "0x1B1E8A8", VA = "0x1B1E8A8")]
	public UIModelMail()
	{
	}

	[Token(Token = "0x6014943")]
	[Address(RVA = "0x1B1EA8C", Offset = "0x1B1EA8C", VA = "0x1B1EA8C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601494C")]
	[Address(RVA = "0x1B1EB24", Offset = "0x1B1EB24", VA = "0x1B1EB24")]
	public List<MailInfo> GetMailInfoList(bool sorted = true)
	{
		return null;
	}

	[Token(Token = "0x601494D")]
	[Address(RVA = "0x1B1EEA0", Offset = "0x1B1EEA0", VA = "0x1B1EEA0")]
	public List<ReportMailInfo> GetReportMailInfoList(bool sorted = true)
	{
		return null;
	}

	[Token(Token = "0x601494E")]
	[Address(RVA = "0x1B1F21C", Offset = "0x1B1F21C", VA = "0x1B1F21C")]
	public List<MailInfo> GetNoReciveGiftMailList()
	{
		return null;
	}

	[Token(Token = "0x601494F")]
	[Address(RVA = "0x1B1F448", Offset = "0x1B1F448", VA = "0x1B1F448", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014950")]
	[Address(RVA = "0x1B1F788", Offset = "0x1B1F788", VA = "0x1B1F788", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014951")]
	[Address(RVA = "0x1B1269C", Offset = "0x1B1269C", VA = "0x1B1269C")]
	public void RequestMailList(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014952")]
	[Address(RVA = "0x1B12A10", Offset = "0x1B12A10", VA = "0x1B12A10")]
	public void RequestReportMailList(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014953")]
	[Address(RVA = "0x1B1ED94", Offset = "0x1B1ED94", VA = "0x1B1ED94")]
	private void SortMailList(List<MailInfo> list)
	{
	}

	[Token(Token = "0x6014954")]
	[Address(RVA = "0x1B1F110", Offset = "0x1B1F110", VA = "0x1B1F110")]
	private void SortReportMailList(List<ReportMailInfo> list)
	{
	}

	[Token(Token = "0x6014955")]
	[Address(RVA = "0x1B1FB54", Offset = "0x1B1FB54", VA = "0x1B1FB54")]
	public void SetMailStatus(EMail.Status status, MailInfo mailInfo, bool isFriendGift = false)
	{
	}

	[Token(Token = "0x6014956")]
	[Address(RVA = "0x1B20614", Offset = "0x1B20614", VA = "0x1B20614")]
	public void SetReportMailStatus(EMail.Status status, ReportMailInfo mailInfo)
	{
	}

	[Token(Token = "0x6014957")]
	[Address(RVA = "0x1B1FC98", Offset = "0x1B1FC98", VA = "0x1B1FC98")]
	public void RequestReadMail(List<MailInfo> mails, EMail.Status status, bool isBatchOp, bool isFriendGift = false)
	{
	}

	[Token(Token = "0x6014958")]
	[Address(RVA = "0x1B20750", Offset = "0x1B20750", VA = "0x1B20750")]
	public void RequestReadReportMail(List<ReportMailInfo> mails, EMail.Status status, bool isBatchOp)
	{
	}

	[Token(Token = "0x6014959")]
	[Address(RVA = "0x1B20C24", Offset = "0x1B20C24", VA = "0x1B20C24")]
	public void CheckIfPopupRewards(EMail.Status type, CSReadMailRes readMailRes)
	{
	}

	[Token(Token = "0x601495A")]
	[Address(RVA = "0x1B21398", Offset = "0x1B21398", VA = "0x1B21398")]
	public bool IsMailRead(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x601495B")]
	[Address(RVA = "0x1B21494", Offset = "0x1B21494", VA = "0x1B21494")]
	public bool IsReportMailRead(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x601495C")]
	[Address(RVA = "0x1B21590", Offset = "0x1B21590", VA = "0x1B21590")]
	public void SetMailRead(ulong id)
	{
	}

	[Token(Token = "0x601495D")]
	[Address(RVA = "0x1B2168C", Offset = "0x1B2168C", VA = "0x1B2168C")]
	public void SetReportMailRead(ulong id)
	{
	}

	[Token(Token = "0x601495E")]
	[Address(RVA = "0x1B21788", Offset = "0x1B21788", VA = "0x1B21788")]
	public void RemoveMailRead(ulong id)
	{
	}

	[Token(Token = "0x601495F")]
	[Address(RVA = "0x1B21884", Offset = "0x1B21884", VA = "0x1B21884")]
	public void RemoveReportMailRead(ulong id)
	{
	}

	[Token(Token = "0x6014960")]
	[Address(RVA = "0x1B21980", Offset = "0x1B21980", VA = "0x1B21980")]
	public void UpdateMailRead()
	{
	}

	[Token(Token = "0x6014961")]
	[Address(RVA = "0x1B21A48", Offset = "0x1B21A48", VA = "0x1B21A48")]
	public void UpdateReportMailRead()
	{
	}

	[Token(Token = "0x6014962")]
	[Address(RVA = "0x1B1F9B8", Offset = "0x1B1F9B8", VA = "0x1B1F9B8")]
	public void SaveMailRead()
	{
	}

	[Token(Token = "0x6014963")]
	[Address(RVA = "0x1B21B10", Offset = "0x1B21B10", VA = "0x1B21B10")]
	public bool HasUnreadMail()
	{
		return default(bool);
	}

	[Token(Token = "0x6014964")]
	[Address(RVA = "0x1B21D0C", Offset = "0x1B21D0C", VA = "0x1B21D0C")]
	public bool HasUnreadReportMail()
	{
		return default(bool);
	}

	[Token(Token = "0x6014965")]
	[Address(RVA = "0x1B21F08", Offset = "0x1B21F08", VA = "0x1B21F08")]
	public bool HasNewMailNtf()
	{
		return default(bool);
	}

	[Token(Token = "0x6014966")]
	[Address(RVA = "0x1B21F98", Offset = "0x1B21F98", VA = "0x1B21F98")]
	public void SetSelectedReportMailAppealInfoToWebView(string mathTime, string mainReasons, List<uint> reportTypeLists)
	{
	}

	[Token(Token = "0x6014967")]
	[Address(RVA = "0x1B220F8", Offset = "0x1B220F8", VA = "0x1B220F8")]
	public string GetSelectedReportMailAppealInfoToWebView()
	{
		return null;
	}

	[Token(Token = "0x6014968")]
	[Address(RVA = "0x1B22440", Offset = "0x1B22440", VA = "0x1B22440")]
	public bool ConditionHasAttachmentMail(MailInfo mail)
	{
		return default(bool);
	}

	[Token(Token = "0x6014969")]
	[Address(RVA = "0x1B224BC", Offset = "0x1B224BC", VA = "0x1B224BC")]
	public bool CheckAttachmentNotNull(MailAttachment attachment)
	{
		return default(bool);
	}

	[Token(Token = "0x601496A")]
	[Address(RVA = "0x1B22648", Offset = "0x1B22648", VA = "0x1B22648")]
	public bool ConditionRecevableMail(MailInfo mail)
	{
		return default(bool);
	}

	[Token(Token = "0x601496B")]
	[Address(RVA = "0x1B226E4", Offset = "0x1B226E4", VA = "0x1B226E4")]
	public bool ConditionProcessableMail(MailInfo mail)
	{
		return default(bool);
	}

	[Token(Token = "0x601496C")]
	[Address(RVA = "0x1B22790", Offset = "0x1B22790", VA = "0x1B22790")]
	public bool ConditionDeletableMail(MailInfo mail)
	{
		return default(bool);
	}

	[Token(Token = "0x601496D")]
	[Address(RVA = "0x1B22838", Offset = "0x1B22838", VA = "0x1B22838")]
	public bool ConditionRecevableReportMail(ReportMailInfo mail)
	{
		return default(bool);
	}

	[Token(Token = "0x601496E")]
	[Address(RVA = "0x1B2289C", Offset = "0x1B2289C", VA = "0x1B2289C")]
	public bool ConditionProcessableReportMail(ReportMailInfo mail)
	{
		return default(bool);
	}

	[Token(Token = "0x601496F")]
	[Address(RVA = "0x1B22900", Offset = "0x1B22900", VA = "0x1B22900")]
	public bool ConditionDeletableReportMail(ReportMailInfo mail)
	{
		return default(bool);
	}

	[Token(Token = "0x6014970")]
	[Address(RVA = "0x1B229A8", Offset = "0x1B229A8", VA = "0x1B229A8")]
	public string MakeUrl(string url)
	{
		return null;
	}

	[Token(Token = "0x6014972")]
	[Address(RVA = "0x1B22F00", Offset = "0x1B22F00", VA = "0x1B22F00")]
	private void _003CRequestMailList_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014973")]
	[Address(RVA = "0x1B2356C", Offset = "0x1B2356C", VA = "0x1B2356C")]
	private void _003CRequestReportMailList_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014974")]
	[Address(RVA = "0x1B23A10", Offset = "0x1B23A10", VA = "0x1B23A10")]
	private int _003CSortMailList_003Em__2(MailInfo a, MailInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6014975")]
	[Address(RVA = "0x1B23AB8", Offset = "0x1B23AB8", VA = "0x1B23AB8")]
	private int _003CSortReportMailList_003Em__3(ReportMailInfo a, ReportMailInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6014976")]
	[Address(RVA = "0x1B23B60", Offset = "0x1B23B60", VA = "0x1B23B60")]
	private static ulong _003CRequestReadMail_003Em__4(MailInfo a)
	{
		return default(ulong);
	}

	[Token(Token = "0x6014977")]
	[Address(RVA = "0x1B23B84", Offset = "0x1B23B84", VA = "0x1B23B84")]
	private static ulong _003CRequestReadReportMail_003Em__5(ReportMailInfo a)
	{
		return default(ulong);
	}

	[Token(Token = "0x6014978")]
	[Address(RVA = "0x1B23BA8", Offset = "0x1B23BA8", VA = "0x1B23BA8")]
	private static CommonRewardItemInfo _003CCheckIfPopupRewards_003Em__6(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x6014979")]
	[Address(RVA = "0x1B23BB0", Offset = "0x1B23BB0", VA = "0x1B23BB0")]
	private static CommonRewardItemInfo _003CCheckIfPopupRewards_003Em__7(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x601497A")]
	[Address(RVA = "0x1B23BB8", Offset = "0x1B23BB8", VA = "0x1B23BB8")]
	private static void _003CCheckIfPopupRewards_003Em__8()
	{
	}

	[Token(Token = "0x601497B")]
	[Address(RVA = "0x1B23C78", Offset = "0x1B23C78", VA = "0x1B23C78")]
	private static int _003CRequestMailList_003Em__9(MailInfo a, MailInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x601497C")]
	[Address(RVA = "0x1B23CD0", Offset = "0x1B23CD0", VA = "0x1B23CD0")]
	private static int _003CRequestReportMailList_003Em__A(ReportMailInfo a, ReportMailInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x601497D")]
	[Address(RVA = "0x1B23D28", Offset = "0x1B23D28", VA = "0x1B23D28")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x601497E")]
	[Address(RVA = "0x1B23D30", Offset = "0x1B23D30", VA = "0x1B23D30")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
