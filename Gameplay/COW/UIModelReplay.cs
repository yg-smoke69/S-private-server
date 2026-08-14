using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200320A")]
internal class UIModelReplay : UIBaseModel
{
	[Token(Token = "0x200320B")]
	public enum Status
	{
		[Token(Token = "0x40130C4")]
		READY,
		[Token(Token = "0x40130C5")]
		PENDING,
		[Token(Token = "0x40130C6")]
		Violation,
		[Token(Token = "0x40130C7")]
		Qualified
	}

	[Token(Token = "0x200320C")]
	public class UploadReq
	{
		[Token(Token = "0x40130C8")]
		[FieldOffset(Offset = "0x8")]
		public ulong video_id;

		[Token(Token = "0x40130C9")]
		[FieldOffset(Offset = "0x10")]
		public int status;

		[Token(Token = "0x40130CA")]
		[FieldOffset(Offset = "0x18")]
		public ulong reported_uid;

		[Token(Token = "0x60151E3")]
		[Address(RVA = "0x2CFDBE0", Offset = "0x2CFDBE0", VA = "0x2CFDBE0")]
		public UploadReq()
		{
		}
	}

	[Token(Token = "0x200320D")]
	public class VerifyRes
	{
		[Token(Token = "0x40130CB")]
		[FieldOffset(Offset = "0x8")]
		public string status;

		[Token(Token = "0x40130CC")]
		[FieldOffset(Offset = "0xC")]
		public string msg;

		[Token(Token = "0x40130CD")]
		[FieldOffset(Offset = "0x10")]
		public VerifyData data;

		[Token(Token = "0x60151E4")]
		[Address(RVA = "0x2CFDBF0", Offset = "0x2CFDBF0", VA = "0x2CFDBF0")]
		public VerifyRes()
		{
		}
	}

	[Token(Token = "0x200320E")]
	public class VerifyData
	{
		[Token(Token = "0x40130CE")]
		[FieldOffset(Offset = "0x8")]
		public bool is_staff;

		[Token(Token = "0x60151E5")]
		[Address(RVA = "0x2CFDBE8", Offset = "0x2CFDBE8", VA = "0x2CFDBE8")]
		public VerifyData()
		{
		}
	}

	[Token(Token = "0x200320F")]
	public class VideosRes
	{
		[Token(Token = "0x40130CF")]
		[FieldOffset(Offset = "0x8")]
		public string status;

		[Token(Token = "0x40130D0")]
		[FieldOffset(Offset = "0xC")]
		public string msg;

		[Token(Token = "0x40130D1")]
		[FieldOffset(Offset = "0x10")]
		public List<ReportReplayInfo> data;

		[Token(Token = "0x60151E6")]
		[Address(RVA = "0x2CFDBF8", Offset = "0x2CFDBF8", VA = "0x2CFDBF8")]
		public VideosRes()
		{
		}
	}

	[Token(Token = "0x2003210")]
	public class ReportReplayInfo
	{
		[Token(Token = "0x40130D2")]
		[FieldOffset(Offset = "0x8")]
		public ulong id;

		[Token(Token = "0x40130D3")]
		[FieldOffset(Offset = "0x10")]
		public ulong match_id;

		[Token(Token = "0x40130D4")]
		[FieldOffset(Offset = "0x18")]
		public int date;

		[Token(Token = "0x40130D5")]
		[FieldOffset(Offset = "0x1C")]
		public int game_mode;

		[Token(Token = "0x40130D6")]
		[FieldOffset(Offset = "0x20")]
		public int group_mode;

		[Token(Token = "0x40130D7")]
		[FieldOffset(Offset = "0x24")]
		public List<Offender> reported;

		[Token(Token = "0x40130D8")]
		[FieldOffset(Offset = "0x28")]
		public int duration;

		[Token(Token = "0x40130D9")]
		[FieldOffset(Offset = "0x2C")]
		public string url;

		[Token(Token = "0x60151E7")]
		[Address(RVA = "0x2CFDBD0", Offset = "0x2CFDBD0", VA = "0x2CFDBD0")]
		public ReportReplayInfo()
		{
		}
	}

	[Token(Token = "0x2003211")]
	public class Offender
	{
		[Token(Token = "0x40130DA")]
		[FieldOffset(Offset = "0x8")]
		public ulong user_id;

		[Token(Token = "0x40130DB")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40130DC")]
		[FieldOffset(Offset = "0x14")]
		public int status;

		[Token(Token = "0x40130DD")]
		[FieldOffset(Offset = "0x18")]
		public List<Reporter> reporters;

		[Token(Token = "0x60151E8")]
		[Address(RVA = "0x2CFDBC8", Offset = "0x2CFDBC8", VA = "0x2CFDBC8")]
		public Offender()
		{
		}
	}

	[Token(Token = "0x2003212")]
	public class Reporter
	{
		[Token(Token = "0x40130DE")]
		[FieldOffset(Offset = "0x8")]
		public ulong user_id;

		[Token(Token = "0x40130DF")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40130E0")]
		[FieldOffset(Offset = "0x14")]
		public int reason;

		[Token(Token = "0x40130E1")]
		[FieldOffset(Offset = "0x18")]
		public int reporter_time_ms;

		[Token(Token = "0x60151E9")]
		[Address(RVA = "0x2CFDBD8", Offset = "0x2CFDBD8", VA = "0x2CFDBD8")]
		public Reporter()
		{
		}
	}

	[Token(Token = "0x40130B9")]
	[FieldOffset(Offset = "0xC")]
	private List<ReplayInfo> m_ReplayInfoList;

	[Token(Token = "0x40130BA")]
	[FieldOffset(Offset = "0x10")]
	private List<ReportReplayInfo> m_ReportReplayInfoList;

	[Token(Token = "0x40130BB")]
	[FieldOffset(Offset = "0x14")]
	public bool IsReportReplay;

	[Token(Token = "0x40130BC")]
	[FieldOffset(Offset = "0x18")]
	private ReportReplayInfo m_CurReportReplayInfo;

	[Token(Token = "0x40130BD")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsStaff;

	[Token(Token = "0x40130BE")]
	[FieldOffset(Offset = "0x20")]
	public readonly string[] STATUS_KEY_ARRAY;

	[Token(Token = "0x40130BF")]
	public const uint PropID_ReplayDeleted = 2u;

	[Token(Token = "0x40130C0")]
	public const uint PropID_GetReportReplays = 4u;

	[Token(Token = "0x40130C1")]
	public const uint PropID_VerifyAccount = 8u;

	[Token(Token = "0x40130C2")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<ReplayInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60151DB")]
	[Address(RVA = "0x2CFD164", Offset = "0x2CFD164", VA = "0x2CFD164")]
	public UIModelReplay()
	{
	}

	[Token(Token = "0x60151DC")]
	[Address(RVA = "0x2CFD5E0", Offset = "0x2CFD5E0", VA = "0x2CFD5E0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60151DD")]
	[Address(RVA = "0x2CFD638", Offset = "0x2CFD638", VA = "0x2CFD638")]
	public List<ReplayInfo> GetAllReplaysByTime()
	{
		return null;
	}

	[Token(Token = "0x60151DE")]
	[Address(RVA = "0x2CFD7EC", Offset = "0x2CFD7EC", VA = "0x2CFD7EC")]
	public bool Play(ReplayInfo info, bool isReportReplay = false, [Optional] ReportReplayInfo reportReplayInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60151DF")]
	[Address(RVA = "0x2CFD950", Offset = "0x2CFD950", VA = "0x2CFD950")]
	public void Del(ReplayInfo info)
	{
	}

	[Token(Token = "0x60151E0")]
	[Address(RVA = "0x2CFDA84", Offset = "0x2CFDA84", VA = "0x2CFDA84", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60151E1")]
	[Address(RVA = "0x2CFDB64", Offset = "0x2CFDB64", VA = "0x2CFDB64")]
	private static int _003CGetAllReplaysByTime_003Em__0(ReplayInfo a, ReplayInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60151E2")]
	[Address(RVA = "0x2CFDBC0", Offset = "0x2CFDBC0", VA = "0x2CFDBC0")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
