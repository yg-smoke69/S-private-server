using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002FCF")]
public class UIModelConnectionReport : UIBaseModel
{
	[Token(Token = "0x2002FD0")]
	private enum EPingNodeState
	{
		[Token(Token = "0x401233F")]
		Waiting,
		[Token(Token = "0x4012340")]
		Running,
		[Token(Token = "0x4012341")]
		Paused
	}

	[Token(Token = "0x2002FD1")]
	private delegate void OnCollectComplete();

	[Token(Token = "0x2002FD2")]
	private sealed class _003CPingGSNode_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012342")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x4012343")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelConnectionReport _0024this;

		[Token(Token = "0x6013FAF")]
		[Address(RVA = "0x31DE790", Offset = "0x31DE790", VA = "0x31DE790")]
		public _003CPingGSNode_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013FB0")]
		[Address(RVA = "0x31E1E08", Offset = "0x31E1E08", VA = "0x31E1E08")]
		internal void _003C_003Em__0(List<NetDetectionResult> result, object extra_data)
		{
		}
	}

	[Token(Token = "0x2002FD3")]
	private sealed class _003CLogin_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012344")]
		[FieldOffset(Offset = "0x8")]
		internal Report_Ping report_ping;

		[Token(Token = "0x4012345")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelConnectionReport _0024this;

		[Token(Token = "0x6013FB1")]
		[Address(RVA = "0x31E10B8", Offset = "0x31E10B8", VA = "0x31E10B8")]
		public _003CLogin_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013FB2")]
		[Address(RVA = "0x31E1B44", Offset = "0x31E1B44", VA = "0x31E1B44")]
		internal void _003C_003Em__0(List<NetDetectionResult> trace_results, object trace_extra_data)
		{
		}
	}

	[Token(Token = "0x401232F")]
	[FieldOffset(Offset = "0x0")]
	public static string[] CHECK_IP_LIST;

	[Token(Token = "0x4012330")]
	[FieldOffset(Offset = "0xC")]
	public bool IsRunningCollectionTraceReport;

	[Token(Token = "0x4012331")]
	[FieldOffset(Offset = "0x10")]
	private uint m_LoginNetworkErrCount;

	[Token(Token = "0x4012332")]
	[FieldOffset(Offset = "0x14")]
	private uint m_ClearCountDelayCallID;

	[Token(Token = "0x4012333")]
	[FieldOffset(Offset = "0x18")]
	private int m_LastDisconnectReason;

	[Token(Token = "0x4012334")]
	public const uint PropID_TraceRouteReportSendingFlagUpdate = 2u;

	[Token(Token = "0x4012335")]
	[FieldOffset(Offset = "0x1C")]
	private bool _003CIsInSendingTraceRouteReport_003Ek__BackingField;

	[Token(Token = "0x4012336")]
	[FieldOffset(Offset = "0x20")]
	private List<PingAddrDesc> m_PingServerIPList;

	[Token(Token = "0x4012337")]
	[FieldOffset(Offset = "0x24")]
	private List<GSNodeInfo> m_GSNodeList;

	[Token(Token = "0x4012338")]
	[FieldOffset(Offset = "0x28")]
	private int m_NextPingIndex;

	[Token(Token = "0x4012339")]
	[FieldOffset(Offset = "0x2C")]
	private EPingNodeState m_PingNodeState;

	[Token(Token = "0x401233A")]
	[FieldOffset(Offset = "0x30")]
	private int m_MaxDetectionCount;

	[Token(Token = "0x401233B")]
	[FieldOffset(Offset = "0x34")]
	private float m_NextDetectionTime;

	[Token(Token = "0x401233C")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, Report_SelfDetection> m_DetectionResults;

	[Token(Token = "0x401233D")]
	[FieldOffset(Offset = "0x4")]
	private static NetworkDetection.MultiTaskComplete _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170014B2")]
	public bool IsInSendingTraceRouteReport
	{
		[Token(Token = "0x6013F8F")]
		[Address(RVA = "0x31DD6FC", Offset = "0x31DD6FC", VA = "0x31DD6FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013F90")]
		[Address(RVA = "0x31DD704", Offset = "0x31DD704", VA = "0x31DD704")]
		private set
		{
		}
	}

	[Token(Token = "0x6013F8E")]
	[Address(RVA = "0x31DD5D4", Offset = "0x31DD5D4", VA = "0x31DD5D4")]
	public UIModelConnectionReport()
	{
	}

	[Token(Token = "0x6013F91")]
	[Address(RVA = "0x31DD70C", Offset = "0x31DD70C", VA = "0x31DD70C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013F92")]
	[Address(RVA = "0x31DD764", Offset = "0x31DD764", VA = "0x31DD764", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6013F93")]
	[Address(RVA = "0x31DDFE0", Offset = "0x31DDFE0", VA = "0x31DDFE0")]
	public void OnFrontEndGameLoaded()
	{
	}

	[Token(Token = "0x6013F94")]
	[Address(RVA = "0x31DE14C", Offset = "0x31DE14C", VA = "0x31DE14C")]
	public void OnFrontEndGameDestroy()
	{
	}

	[Token(Token = "0x6013F95")]
	[Address(RVA = "0x31DDEEC", Offset = "0x31DDEEC", VA = "0x31DDEEC")]
	public void StartIDCPing(int start_index = 0)
	{
	}

	[Token(Token = "0x6013F96")]
	[Address(RVA = "0x31DE5BC", Offset = "0x31DE5BC", VA = "0x31DE5BC")]
	public void ConstractIDCPingResult(List<AccountIDCPingInfo> ping_list)
	{
	}

	[Token(Token = "0x6013F97")]
	[Address(RVA = "0x31DE294", Offset = "0x31DE294", VA = "0x31DE294")]
	private void PingGSNode(int index)
	{
	}

	[Token(Token = "0x6013F98")]
	[Address(RVA = "0x31DE798", Offset = "0x31DE798", VA = "0x31DE798")]
	public static bool HasNeedCheckIP()
	{
		return default(bool);
	}

	[Token(Token = "0x6013F99")]
	[Address(RVA = "0x31DE85C", Offset = "0x31DE85C", VA = "0x31DE85C")]
	public bool CheckNeedShowWhenLoginFailed()
	{
		return default(bool);
	}

	[Token(Token = "0x6013F9A")]
	[Address(RVA = "0x31DEAB0", Offset = "0x31DEAB0", VA = "0x31DEAB0")]
	public void OnServiceDisconnect(DisconnectedReason reason)
	{
	}

	[Token(Token = "0x6013F9B")]
	[Address(RVA = "0x31DEB1C", Offset = "0x31DEB1C", VA = "0x31DEB1C")]
	public void CheckLastDisconnectReason()
	{
	}

	[Token(Token = "0x6013F9C")]
	[Address(RVA = "0x31DEB78", Offset = "0x31DEB78", VA = "0x31DEB78")]
	public void CollectNetworkReportAndSend(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013F9D")]
	[Address(RVA = "0x31DEDF4", Offset = "0x31DEDF4", VA = "0x31DEDF4")]
	public void SelfNetworkDetection(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013F9E")]
	[Address(RVA = "0x31DF330", Offset = "0x31DF330", VA = "0x31DF330")]
	private void OnModuleDetectionTaskFinished(List<NetDetectionResult> results, object extra_data)
	{
	}

	[Token(Token = "0x6013F9F")]
	[Address(RVA = "0x31DF76C", Offset = "0x31DF76C", VA = "0x31DF76C")]
	private void OnDectectionTaskFinished()
	{
	}

	[Token(Token = "0x6013FA0")]
	[Address(RVA = "0x31E0380", Offset = "0x31E0380", VA = "0x31E0380")]
	public static void CollectCDNDownloadReportAndSend(string url)
	{
	}

	[Token(Token = "0x6013FA1")]
	[Address(RVA = "0x31E02A4", Offset = "0x31E02A4", VA = "0x31E02A4")]
	private void OnSendedReport()
	{
	}

	[Token(Token = "0x6013FA2")]
	[Address(RVA = "0x31E04BC", Offset = "0x31E04BC", VA = "0x31E04BC")]
	private void SendPingReport(Report_Ping report_Ping)
	{
	}

	[Token(Token = "0x6013FA3")]
	[Address(RVA = "0x31E06E8", Offset = "0x31E06E8", VA = "0x31E06E8")]
	private void SendTraceReport(Report_TraceRoute report_TraceRoute)
	{
	}

	[Token(Token = "0x6013FA4")]
	[Address(RVA = "0x31E08E0", Offset = "0x31E08E0", VA = "0x31E08E0")]
	private static void SendCDNTestReport(Report_CDNDownload report)
	{
	}

	[Token(Token = "0x6013FA5")]
	[Address(RVA = "0x31E0B04", Offset = "0x31E0B04", VA = "0x31E0B04")]
	private void _003CLogin_003Em__0(List<NetDetectionResult> ping_results, object extra_data)
	{
	}

	[Token(Token = "0x6013FA6")]
	[Address(RVA = "0x31E10C0", Offset = "0x31E10C0", VA = "0x31E10C0")]
	private void _003CCheckNeedShowWhenLoginFailed_003Em__1()
	{
	}

	[Token(Token = "0x6013FA7")]
	[Address(RVA = "0x31E10CC", Offset = "0x31E10CC", VA = "0x31E10CC")]
	private void _003CCollectNetworkReportAndSend_003Em__2(List<NetDetectionResult> ping_results, object ping_extra_data)
	{
	}

	[Token(Token = "0x6013FA8")]
	[Address(RVA = "0x31E1394", Offset = "0x31E1394", VA = "0x31E1394")]
	private void _003CSelfNetworkDetection_003Em__3(HttpErrorCode error_code, object res)
	{
	}

	[Token(Token = "0x6013FA9")]
	[Address(RVA = "0x31E1738", Offset = "0x31E1738", VA = "0x31E1738")]
	private static void _003CCollectCDNDownloadReportAndSend_003Em__4(List<NetDetectionResult> results, object extra_data)
	{
	}

	[Token(Token = "0x6013FAA")]
	[Address(RVA = "0x31E1B3C", Offset = "0x31E1B3C", VA = "0x31E1B3C")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
