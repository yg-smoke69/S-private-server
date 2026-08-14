using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002F42")]
public class UIModelChummy : UIBaseModel
{
	[Token(Token = "0x2002F43")]
	public enum TrainingCampAwardStatus
	{
		[Token(Token = "0x40120E3")]
		None,
		[Token(Token = "0x40120E4")]
		Received,
		[Token(Token = "0x40120E5")]
		Finished,
		[Token(Token = "0x40120E6")]
		Claimed
	}

	[Token(Token = "0x2002F44")]
	private sealed class _003CRequestChummyIntimacyAwardInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x40120E7")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x40120E8")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013C96")]
		[Address(RVA = "0x33475CC", Offset = "0x33475CC", VA = "0x33475CC")]
		public _003CRequestChummyIntimacyAwardInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013C97")]
		[Address(RVA = "0x33475D4", Offset = "0x33475D4", VA = "0x33475D4")]
		internal bool _003C_003Em__0(AccountInfoWithChummyState item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F45")]
	private sealed class _003CRequestClaimChummyIntimacyAward_003Ec__AnonStorey1
	{
		[Token(Token = "0x40120E9")]
		[FieldOffset(Offset = "0x8")]
		internal uint rank;

		[Token(Token = "0x40120EA")]
		[FieldOffset(Offset = "0xC")]
		internal CSClaimChummyIntimacyAwardReq req;

		[Token(Token = "0x40120EB")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x40120EC")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x40120ED")]
		[FieldOffset(Offset = "0x4")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6013C98")]
		[Address(RVA = "0x33476D4", Offset = "0x33476D4", VA = "0x33476D4")]
		public _003CRequestClaimChummyIntimacyAward_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013C99")]
		[Address(RVA = "0x33476DC", Offset = "0x33476DC", VA = "0x33476DC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013C9A")]
		[Address(RVA = "0x3347B60", Offset = "0x3347B60", VA = "0x3347B60")]
		private static BaseItemInfo _003C_003Em__1(AwardDesc item)
		{
			return null;
		}

		[Token(Token = "0x6013C9B")]
		[Address(RVA = "0x3347BE4", Offset = "0x3347BE4", VA = "0x3347BE4")]
		private static CommonRewardItemInfo _003C_003Em__2(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002F46")]
	private sealed class _003CRequestClaimChummyIntimacyAward_003Ec__AnonStorey2
	{
		[Token(Token = "0x40120EE")]
		[FieldOffset(Offset = "0x8")]
		internal uint rank;

		[Token(Token = "0x40120EF")]
		[FieldOffset(Offset = "0x10")]
		internal ulong id;

		[Token(Token = "0x40120F0")]
		[FieldOffset(Offset = "0x18")]
		internal CSClaimChummyIntimacyAwardReq req;

		[Token(Token = "0x40120F1")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x40120F2")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x40120F3")]
		[FieldOffset(Offset = "0x4")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6013C9C")]
		[Address(RVA = "0x3347BEC", Offset = "0x3347BEC", VA = "0x3347BEC")]
		public _003CRequestClaimChummyIntimacyAward_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013C9D")]
		[Address(RVA = "0x3347BF4", Offset = "0x3347BF4", VA = "0x3347BF4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013C9E")]
		[Address(RVA = "0x33483F0", Offset = "0x33483F0", VA = "0x33483F0")]
		private static BaseItemInfo _003C_003Em__1(AwardDesc item)
		{
			return null;
		}

		[Token(Token = "0x6013C9F")]
		[Address(RVA = "0x3348474", Offset = "0x3348474", VA = "0x3348474")]
		private static CommonRewardItemInfo _003C_003Em__2(BaseItemInfo item)
		{
			return null;
		}

		[Token(Token = "0x6013CA0")]
		[Address(RVA = "0x334847C", Offset = "0x334847C", VA = "0x334847C")]
		internal void _003C_003Em__3()
		{
		}

		[Token(Token = "0x6013CA1")]
		[Address(RVA = "0x3348514", Offset = "0x3348514", VA = "0x3348514")]
		internal bool _003C_003Em__4(AccountInfoWithChummyState item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F47")]
	private sealed class _003CRequestAddingChummy_003Ec__AnonStorey3
	{
		[Token(Token = "0x40120F4")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x40120F5")]
		[FieldOffset(Offset = "0x10")]
		internal bool isFromChat;

		[Token(Token = "0x40120F6")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CA2")]
		[Address(RVA = "0x334731C", Offset = "0x334731C", VA = "0x334731C")]
		public _003CRequestAddingChummy_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6013CA3")]
		[Address(RVA = "0x3347324", Offset = "0x3347324", VA = "0x3347324")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F48")]
	private sealed class _003CRequestDismissChummy_003Ec__AnonStorey4
	{
		[Token(Token = "0x40120F7")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EChummy.RequestType requestType;

		[Token(Token = "0x40120F8")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CA4")]
		[Address(RVA = "0x334887C", Offset = "0x334887C", VA = "0x334887C")]
		public _003CRequestDismissChummy_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6013CA5")]
		[Address(RVA = "0x3348884", Offset = "0x3348884", VA = "0x3348884")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F49")]
	private sealed class _003CRequestConfirmAddingChummy_003Ec__AnonStorey5
	{
		[Token(Token = "0x40120F9")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x40120FA")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CA6")]
		[Address(RVA = "0x3348568", Offset = "0x3348568", VA = "0x3348568")]
		public _003CRequestConfirmAddingChummy_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6013CA7")]
		[Address(RVA = "0x3348570", Offset = "0x3348570", VA = "0x3348570")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F4A")]
	private sealed class _003CRequestDeclineAddingChummy_003Ec__AnonStorey6
	{
		[Token(Token = "0x40120FB")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x40120FC")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CA8")]
		[Address(RVA = "0x3348680", Offset = "0x3348680", VA = "0x3348680")]
		public _003CRequestDeclineAddingChummy_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6013CA9")]
		[Address(RVA = "0x3348688", Offset = "0x3348688", VA = "0x3348688")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F4B")]
	private sealed class _003CRequestConfirmDismissChummy_003Ec__AnonStorey7
	{
		[Token(Token = "0x40120FD")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x40120FE")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CAA")]
		[Address(RVA = "0x33485F4", Offset = "0x33485F4", VA = "0x33485F4")]
		public _003CRequestConfirmDismissChummy_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6013CAB")]
		[Address(RVA = "0x33485FC", Offset = "0x33485FC", VA = "0x33485FC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F4C")]
	private sealed class _003CRequestDeclineDismissChummy_003Ec__AnonStorey8
	{
		[Token(Token = "0x40120FF")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x4012100")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CAC")]
		[Address(RVA = "0x33486CC", Offset = "0x33486CC", VA = "0x33486CC")]
		public _003CRequestDeclineDismissChummy_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6013CAD")]
		[Address(RVA = "0x33486D4", Offset = "0x33486D4", VA = "0x33486D4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F4D")]
	private sealed class _003COnChummyDismissedNtf_003Ec__AnonStorey9
	{
		[Token(Token = "0x4012101")]
		[FieldOffset(Offset = "0x8")]
		internal ChummyDismissedNtf ntf;

		[Token(Token = "0x6013CAE")]
		[Address(RVA = "0x27D7FA8", Offset = "0x27D7FA8", VA = "0x27D7FA8")]
		public _003COnChummyDismissedNtf_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6013CAF")]
		[Address(RVA = "0x27DCF9C", Offset = "0x27DCF9C", VA = "0x27DCF9C")]
		internal bool _003C_003Em__0(AccountInfoWithChummyState item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F4E")]
	private sealed class _003COnChummyStateChangeNtf_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4012102")]
		[FieldOffset(Offset = "0x8")]
		internal ChummyStateChangeNtf ntf;

		[Token(Token = "0x6013CB0")]
		[Address(RVA = "0x27D8740", Offset = "0x27D8740", VA = "0x27D8740")]
		public _003COnChummyStateChangeNtf_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6013CB1")]
		[Address(RVA = "0x27DD05C", Offset = "0x27DD05C", VA = "0x27DD05C")]
		internal bool _003C_003Em__0(AccountInfoWithChummyState item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F4F")]
	private sealed class _003COnIntimacyChangeNtf_003Ec__AnonStoreyB
	{
		[Token(Token = "0x4012103")]
		[FieldOffset(Offset = "0x8")]
		internal ChummyIntimacyChangeNtf ntf;

		[Token(Token = "0x6013CB2")]
		[Address(RVA = "0x27D8CDC", Offset = "0x27D8CDC", VA = "0x27D8CDC")]
		public _003COnIntimacyChangeNtf_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6013CB3")]
		[Address(RVA = "0x27DD11C", Offset = "0x27DD11C", VA = "0x27DD11C")]
		internal bool _003C_003Em__0(AccountInfoWithChummyState item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F50")]
	private sealed class _003CGetMultiRelationTypeInfoDesc_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4012104")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EChummy.MultiRelationType type;

		[Token(Token = "0x6013CB4")]
		[Address(RVA = "0x27D8CE4", Offset = "0x27D8CE4", VA = "0x27D8CE4")]
		public _003CGetMultiRelationTypeInfoDesc_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6013CB5")]
		[Address(RVA = "0x27DCBDC", Offset = "0x27DCBDC", VA = "0x27DCBDC")]
		internal bool _003C_003Em__0(MultiRelationTypeInfoDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F51")]
	private sealed class _003CRemoveRequestFromList_003Ec__AnonStoreyD
	{
		[Token(Token = "0x4012105")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6013CB6")]
		[Address(RVA = "0x33472C0", Offset = "0x33472C0", VA = "0x33472C0")]
		public _003CRemoveRequestFromList_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x6013CB7")]
		[Address(RVA = "0x33472C8", Offset = "0x33472C8", VA = "0x33472C8")]
		internal bool _003C_003Em__0(ChummyRequest item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F52")]
	private sealed class _003CIsTrainingCampAvatarOpen_003Ec__AnonStoreyE
	{
		[Token(Token = "0x4012106")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EChummy.MultiRelationType multiRelationType;

		[Token(Token = "0x6013CB8")]
		[Address(RVA = "0x27D9A4C", Offset = "0x27D9A4C", VA = "0x27D9A4C")]
		public _003CIsTrainingCampAvatarOpen_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x6013CB9")]
		[Address(RVA = "0x27DCF64", Offset = "0x27DCF64", VA = "0x27DCF64")]
		internal bool _003C_003Em__0(MultiRelationTypeInfoDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F53")]
	private sealed class _003CGetIntimacyAwardDesc_003Ec__AnonStoreyF
	{
		[Token(Token = "0x4012107")]
		[FieldOffset(Offset = "0x8")]
		internal uint intimacyRank;

		[Token(Token = "0x4012108")]
		[FieldOffset(Offset = "0xC")]
		internal proto.EChummy.MultiRelationType relationType;

		[Token(Token = "0x4012109")]
		[FieldOffset(Offset = "0x10")]
		internal proto.EChummy.Role role;

		[Token(Token = "0x6013CBA")]
		[Address(RVA = "0x27DA074", Offset = "0x27DA074", VA = "0x27DA074")]
		public _003CGetIntimacyAwardDesc_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x6013CBB")]
		[Address(RVA = "0x27DCB80", Offset = "0x27DCB80", VA = "0x27DCB80")]
		internal bool _003C_003Em__0(MultiIntimacyRankAwardDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F54")]
	private sealed class _003CGetBreakUpCountDown_003Ec__AnonStorey10
	{
		[Token(Token = "0x401210A")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EChummy.MultiRelationType relationType;

		[Token(Token = "0x6013CBC")]
		[Address(RVA = "0x27DA1D0", Offset = "0x27DA1D0", VA = "0x27DA1D0")]
		public _003CGetBreakUpCountDown_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x6013CBD")]
		[Address(RVA = "0x27DCA08", Offset = "0x27DCA08", VA = "0x27DCA08")]
		internal bool _003C_003Em__0(MultiRelationTypeInfoDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F55")]
	private sealed class _003CGetRejectCountDown_003Ec__AnonStorey11
	{
		[Token(Token = "0x401210B")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EChummy.MultiRelationType relationType;

		[Token(Token = "0x6013CBE")]
		[Address(RVA = "0x27DA32C", Offset = "0x27DA32C", VA = "0x27DA32C")]
		public _003CGetRejectCountDown_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x6013CBF")]
		[Address(RVA = "0x27DCC34", Offset = "0x27DCC34", VA = "0x27DCC34")]
		internal bool _003C_003Em__0(MultiRelationTypeInfoDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F56")]
	private sealed class _003CGetRelationDisableTime_003Ec__AnonStorey12
	{
		[Token(Token = "0x401210C")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EChummy.MultiRelationType relationType;

		[Token(Token = "0x6013CC0")]
		[Address(RVA = "0x27DA488", Offset = "0x27DA488", VA = "0x27DA488")]
		public _003CGetRelationDisableTime_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x6013CC1")]
		[Address(RVA = "0x27DCC6C", Offset = "0x27DCC6C", VA = "0x27DCC6C")]
		internal bool _003C_003Em__0(MultiRelationTypeInfoDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F57")]
	private sealed class _003CIfAvatarOpen_003Ec__AnonStorey13
	{
		[Token(Token = "0x401210D")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EChummy.MultiRelationType relationType;

		[Token(Token = "0x6013CC2")]
		[Address(RVA = "0x27DA5F0", Offset = "0x27DA5F0", VA = "0x27DA5F0")]
		public _003CIfAvatarOpen_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x6013CC3")]
		[Address(RVA = "0x27DCCE4", Offset = "0x27DCCE4", VA = "0x27DCCE4")]
		internal bool _003C_003Em__0(MultiRelationTypeInfoDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F58")]
	private sealed class _003CGetStudentNameById_003Ec__AnonStorey14
	{
		[Token(Token = "0x401210E")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6013CC4")]
		[Address(RVA = "0x27DADAC", Offset = "0x27DADAC", VA = "0x27DADAC")]
		public _003CGetStudentNameById_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x6013CC5")]
		[Address(RVA = "0x27DCCA4", Offset = "0x27DCCA4", VA = "0x27DCCA4")]
		internal bool _003C_003Em__0(AccountInfoWithChummyState item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F59")]
	private sealed class _003CGetRankFromMilestone_003Ec__AnonStorey15
	{
		[Token(Token = "0x401210F")]
		[FieldOffset(Offset = "0x8")]
		internal uint milestone;

		[Token(Token = "0x6013CC6")]
		[Address(RVA = "0x27DAF24", Offset = "0x27DAF24", VA = "0x27DAF24")]
		public _003CGetRankFromMilestone_003Ec__AnonStorey15()
		{
		}

		[Token(Token = "0x6013CC7")]
		[Address(RVA = "0x27DCC10", Offset = "0x27DCC10", VA = "0x27DCC10")]
		internal bool _003C_003Em__0(MultiIntimacyRankAwardDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F5A")]
	private sealed class _003CGetClaimAwardStudentChummyId_003Ec__AnonStorey17
	{
		[Token(Token = "0x4012110")]
		[FieldOffset(Offset = "0x8")]
		internal uint milestone;

		[Token(Token = "0x4012111")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CC8")]
		[Address(RVA = "0x27DAF2C", Offset = "0x27DAF2C", VA = "0x27DAF2C")]
		public _003CGetClaimAwardStudentChummyId_003Ec__AnonStorey17()
		{
		}
	}

	[Token(Token = "0x2002F5B")]
	private sealed class _003CGetClaimAwardStudentChummyId_003Ec__AnonStorey16
	{
		[Token(Token = "0x4012112")]
		[FieldOffset(Offset = "0x8")]
		internal AccountInfoWithChummyState student;

		[Token(Token = "0x4012113")]
		[FieldOffset(Offset = "0xC")]
		internal _003CGetClaimAwardStudentChummyId_003Ec__AnonStorey17 _003C_003Ef__ref_002423;

		[Token(Token = "0x6013CC9")]
		[Address(RVA = "0x27DAF34", Offset = "0x27DAF34", VA = "0x27DAF34")]
		public _003CGetClaimAwardStudentChummyId_003Ec__AnonStorey16()
		{
		}

		[Token(Token = "0x6013CCA")]
		[Address(RVA = "0x27DCA40", Offset = "0x27DCA40", VA = "0x27DCA40")]
		internal bool _003C_003Em__0(ChummyIntimacyAwardInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F5C")]
	private sealed class _003CTutorAwardAvailableCount_003Ec__AnonStorey19
	{
		[Token(Token = "0x4012114")]
		[FieldOffset(Offset = "0x8")]
		internal uint milestone;

		[Token(Token = "0x4012115")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CCB")]
		[Address(RVA = "0x3348FD0", Offset = "0x3348FD0", VA = "0x3348FD0")]
		public _003CTutorAwardAvailableCount_003Ec__AnonStorey19()
		{
		}
	}

	[Token(Token = "0x2002F5D")]
	private sealed class _003CTutorAwardAvailableCount_003Ec__AnonStorey18
	{
		[Token(Token = "0x4012116")]
		[FieldOffset(Offset = "0x8")]
		internal AccountInfoWithChummyState student;

		[Token(Token = "0x4012117")]
		[FieldOffset(Offset = "0xC")]
		internal _003CTutorAwardAvailableCount_003Ec__AnonStorey19 _003C_003Ef__ref_002425;

		[Token(Token = "0x6013CCC")]
		[Address(RVA = "0x3348E84", Offset = "0x3348E84", VA = "0x3348E84")]
		public _003CTutorAwardAvailableCount_003Ec__AnonStorey18()
		{
		}

		[Token(Token = "0x6013CCD")]
		[Address(RVA = "0x3348E8C", Offset = "0x3348E8C", VA = "0x3348E8C")]
		internal bool _003C_003Em__0(ChummyIntimacyAwardInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F5E")]
	private sealed class _003CIsStudentAwardClaimed_003Ec__AnonStorey1A
	{
		[Token(Token = "0x4012118")]
		[FieldOffset(Offset = "0x8")]
		internal uint milestone;

		[Token(Token = "0x4012119")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChummy _0024this;

		[Token(Token = "0x6013CCE")]
		[Address(RVA = "0x27DB4E4", Offset = "0x27DB4E4", VA = "0x27DB4E4")]
		public _003CIsStudentAwardClaimed_003Ec__AnonStorey1A()
		{
		}

		[Token(Token = "0x6013CCF")]
		[Address(RVA = "0x27DCE18", Offset = "0x27DCE18", VA = "0x27DCE18")]
		internal bool _003C_003Em__0(ChummyIntimacyAwardInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F5F")]
	private sealed class _003CIsRevokeDismissAvailable_003Ec__AnonStorey1B
	{
		[Token(Token = "0x401211A")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6013CD0")]
		[Address(RVA = "0x27DBD60", Offset = "0x27DBD60", VA = "0x27DBD60")]
		public _003CIsRevokeDismissAvailable_003Ec__AnonStorey1B()
		{
		}

		[Token(Token = "0x6013CD1")]
		[Address(RVA = "0x27DCD1C", Offset = "0x27DCD1C", VA = "0x27DCD1C")]
		internal bool _003C_003Em__0(AccountInfoWithChummyState item)
		{
			return default(bool);
		}

		[Token(Token = "0x6013CD2")]
		[Address(RVA = "0x27DCD68", Offset = "0x27DCD68", VA = "0x27DCD68")]
		internal bool _003C_003Em__1(ChummyRequest item)
		{
			return default(bool);
		}

		[Token(Token = "0x6013CD3")]
		[Address(RVA = "0x27DCDC0", Offset = "0x27DCDC0", VA = "0x27DCDC0")]
		internal bool _003C_003Em__2(ChummyRequest item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40120C3")]
	public const uint PropID_TrainingCampDescReady = 1u;

	[Token(Token = "0x40120C4")]
	public const uint PropID_TrainingCampRoleUpdate = 2u;

	[Token(Token = "0x40120C5")]
	public const uint PropID_RefreshRecommendList = 4u;

	[Token(Token = "0x40120C6")]
	public const uint PropID_AddingChummyRequestSent = 8u;

	[Token(Token = "0x40120C7")]
	public const uint PropID_DismissChummyRequestSent = 16u;

	[Token(Token = "0x40120C8")]
	public const uint PropID_AddingChummyResponseSent = 32u;

	[Token(Token = "0x40120C9")]
	public const uint PropID_DismissChummyResponseSent = 64u;

	[Token(Token = "0x40120CA")]
	public const uint PropID_DismissChummyCallbackSent = 128u;

	[Token(Token = "0x40120CB")]
	public const uint PropID_ChummyRequestUpdate = 256u;

	[Token(Token = "0x40120CC")]
	public const uint PropID_ChummyIntimacyAwardInfoUpdate = 512u;

	[Token(Token = "0x40120CD")]
	public const uint PropID_TrainingCampChummyUpdate = 1024u;

	[Token(Token = "0x40120CE")]
	public const int MAX_STUDENT_COUNT = 3;

	[Token(Token = "0x40120CF")]
	public const int TRAININGCAMP_PROGRESS_INTERVAL = 5;

	[Token(Token = "0x40120D0")]
	public const int RECOMMEND_LIST_COUNT = 5;

	[Token(Token = "0x40120D1")]
	public const uint GRADUATE_RANK = 99u;

	[Token(Token = "0x40120D2")]
	[FieldOffset(Offset = "0xC")]
	private CSGetAllChummyDescRes m_ChummyDesc;

	[Token(Token = "0x40120D3")]
	[FieldOffset(Offset = "0x10")]
	private CSGetChummyStateRes m_ChummyStateRes;

	[Token(Token = "0x40120D4")]
	[FieldOffset(Offset = "0x14")]
	private List<AccountInfoWithChummyState> m_ChummyStudentList;

	[Token(Token = "0x40120D5")]
	[FieldOffset(Offset = "0x18")]
	private AccountInfoWithChummyState m_ChummyTutor;

	[Token(Token = "0x40120D6")]
	[FieldOffset(Offset = "0x1C")]
	private MentoringRelationInfo m_ChummyMentoringRelationInfo;

	[Token(Token = "0x40120D7")]
	[FieldOffset(Offset = "0x20")]
	private CSGetRecommendedMentorListRes m_RecommendedMentorListRes;

	[Token(Token = "0x40120D8")]
	[FieldOffset(Offset = "0x24")]
	private CSGetRecommendedStudentListRes m_RecommendedStudentListRes;

	[Token(Token = "0x40120D9")]
	[FieldOffset(Offset = "0x28")]
	private CSGetChummyRequestsRes m_ChummyRequestsRes;

	[Token(Token = "0x40120DA")]
	[FieldOffset(Offset = "0x2C")]
	private UITrainingCampRole m_TrainingCampRoleState;

	[Token(Token = "0x40120DB")]
	[FieldOffset(Offset = "0x30")]
	private proto.EChummy.Role m_TrainingCampRole;

	[Token(Token = "0x40120DC")]
	[FieldOffset(Offset = "0x34")]
	private List<ChummyIntimacyAwardInfo> m_AwardedChummyAwardInfoList;

	[Token(Token = "0x40120DD")]
	[FieldOffset(Offset = "0x38")]
	private bool _003CIsGraduateWndOpen_003Ek__BackingField;

	[Token(Token = "0x40120DE")]
	[FieldOffset(Offset = "0x39")]
	private bool _003CIsInTrainingCamp_003Ek__BackingField;

	[Token(Token = "0x40120DF")]
	[FieldOffset(Offset = "0x3C")]
	private List<MentorTitleData> m_MentorTitleList;

	[Token(Token = "0x40120E0")]
	[FieldOffset(Offset = "0x40")]
	public List<uint> StudentShowList;

	[Token(Token = "0x40120E1")]
	[FieldOffset(Offset = "0x44")]
	public List<uint> TutorShowList;

	[Token(Token = "0x17001479")]
	public List<AccountInfoWithChummyState> ChummyStudentList
	{
		[Token(Token = "0x6013C44")]
		[Address(RVA = "0x27CF370", Offset = "0x27CF370", VA = "0x27CF370")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013C45")]
		[Address(RVA = "0x27D3FB8", Offset = "0x27D3FB8", VA = "0x27D3FB8")]
		set
		{
		}
	}

	[Token(Token = "0x1700147A")]
	public AccountInfoWithChummyState ChummyTutor
	{
		[Token(Token = "0x6013C46")]
		[Address(RVA = "0x27D4018", Offset = "0x27D4018", VA = "0x27D4018")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013C47")]
		[Address(RVA = "0x27D4070", Offset = "0x27D4070", VA = "0x27D4070")]
		set
		{
		}
	}

	[Token(Token = "0x1700147B")]
	public List<ChummyIntimacyAwardInfo> AwardedChummyAwardInfoList
	{
		[Token(Token = "0x6013C48")]
		[Address(RVA = "0x27D40D0", Offset = "0x27D40D0", VA = "0x27D40D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013C49")]
		[Address(RVA = "0x27D4128", Offset = "0x27D4128", VA = "0x27D4128")]
		set
		{
		}
	}

	[Token(Token = "0x1700147C")]
	public bool IsGraduateWndOpen
	{
		[Token(Token = "0x6013C4B")]
		[Address(RVA = "0x27D42D8", Offset = "0x27D42D8", VA = "0x27D42D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013C4C")]
		[Address(RVA = "0x27D42E0", Offset = "0x27D42E0", VA = "0x27D42E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700147D")]
	public bool IsInTrainingCamp
	{
		[Token(Token = "0x6013C4D")]
		[Address(RVA = "0x27D42E8", Offset = "0x27D42E8", VA = "0x27D42E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013C4E")]
		[Address(RVA = "0x27D42F0", Offset = "0x27D42F0", VA = "0x27D42F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700147E")]
	public UITrainingCampRole TrainingCampRoleState
	{
		[Token(Token = "0x6013C6F")]
		[Address(RVA = "0x27C7840", Offset = "0x27C7840", VA = "0x27C7840")]
		get
		{
			return default(UITrainingCampRole);
		}
	}

	[Token(Token = "0x1700147F")]
	public proto.EChummy.Role TrainingCampRole
	{
		[Token(Token = "0x6013C70")]
		[Address(RVA = "0x27D9A54", Offset = "0x27D9A54", VA = "0x27D9A54")]
		get
		{
			return default(proto.EChummy.Role);
		}
	}

	[Token(Token = "0x6013C42")]
	[Address(RVA = "0x27D3EDC", Offset = "0x27D3EDC", VA = "0x27D3EDC")]
	public UIModelChummy()
	{
	}

	[Token(Token = "0x6013C43")]
	[Address(RVA = "0x27D3F60", Offset = "0x27D3F60", VA = "0x27D3F60", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013C4A")]
	[Address(RVA = "0x27CF3C8", Offset = "0x27CF3C8", VA = "0x27CF3C8")]
	public uint GetMutiRelationMaxCnt()
	{
		return default(uint);
	}

	[Token(Token = "0x6013C4F")]
	[Address(RVA = "0x27D42F8", Offset = "0x27D42F8", VA = "0x27D42F8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013C50")]
	[Address(RVA = "0x27D446C", Offset = "0x27D446C", VA = "0x27D446C")]
	public void RequestChummyDesc()
	{
	}

	[Token(Token = "0x6013C51")]
	[Address(RVA = "0x27D4714", Offset = "0x27D4714", VA = "0x27D4714")]
	public void RequestChummyIntimacyAwardInfo()
	{
	}

	[Token(Token = "0x6013C52")]
	[Address(RVA = "0x27D4BDC", Offset = "0x27D4BDC", VA = "0x27D4BDC")]
	public void RequestClaimChummyIntimacyAward(uint milestone)
	{
	}

	[Token(Token = "0x6013C53")]
	[Address(RVA = "0x27D55C4", Offset = "0x27D55C4", VA = "0x27D55C4")]
	public void RequestClaimChummyIntimacyAward(uint rank, ulong id)
	{
	}

	[Token(Token = "0x6013C54")]
	[Address(RVA = "0x27D599C", Offset = "0x27D599C", VA = "0x27D599C")]
	public void RequestGetChummyState(bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013C55")]
	[Address(RVA = "0x27D5C5C", Offset = "0x27D5C5C", VA = "0x27D5C5C")]
	public void RequestApplyForTutor()
	{
	}

	[Token(Token = "0x6013C56")]
	[Address(RVA = "0x27D5ED8", Offset = "0x27D5ED8", VA = "0x27D5ED8")]
	public void RequestRecommendedMentorList(bool force = false)
	{
	}

	[Token(Token = "0x6013C57")]
	[Address(RVA = "0x27D618C", Offset = "0x27D618C", VA = "0x27D618C")]
	public void RequestRecommendedStudentList(bool force = false)
	{
	}

	[Token(Token = "0x6013C58")]
	[Address(RVA = "0x27CF64C", Offset = "0x27CF64C", VA = "0x27CF64C")]
	public void RequestAddingChummy(ulong accountId, proto.EChummy.MultiRelationType relationType, proto.EChummy.RequestType requestType, bool isFromChat = false)
	{
	}

	[Token(Token = "0x6013C59")]
	[Address(RVA = "0x27D6440", Offset = "0x27D6440", VA = "0x27D6440")]
	public void RequestDismissChummy(ulong accountId, proto.EChummy.MultiRelationType relationType, proto.EChummy.RequestType requestType)
	{
	}

	[Token(Token = "0x6013C5A")]
	[Address(RVA = "0x27D679C", Offset = "0x27D679C", VA = "0x27D679C")]
	public void RequestConfirmAddingChummy(ulong accountId, proto.EChummy.MultiRelationType relationType, proto.EChummy.RequestType requestType)
	{
	}

	[Token(Token = "0x6013C5B")]
	[Address(RVA = "0x27D6AE4", Offset = "0x27D6AE4", VA = "0x27D6AE4")]
	public void RequestDeclineAddingChummy(ulong accountId, proto.EChummy.MultiRelationType relationType, proto.EChummy.RequestType requestType)
	{
	}

	[Token(Token = "0x6013C5C")]
	[Address(RVA = "0x27D6E2C", Offset = "0x27D6E2C", VA = "0x27D6E2C")]
	public void RequestConfirmDismissChummy(ulong accountId, proto.EChummy.MultiRelationType relationType, proto.EChummy.RequestType requestType)
	{
	}

	[Token(Token = "0x6013C5D")]
	[Address(RVA = "0x27D7174", Offset = "0x27D7174", VA = "0x27D7174")]
	public void RequestDeclineDismissChummy(ulong accountId, proto.EChummy.MultiRelationType relationType, proto.EChummy.RequestType requestType)
	{
	}

	[Token(Token = "0x6013C5E")]
	[Address(RVA = "0x27D74BC", Offset = "0x27D74BC", VA = "0x27D74BC")]
	public void RequestCallbackDismissChummy(ulong accountId, proto.EChummy.MultiRelationType relationType)
	{
	}

	[Token(Token = "0x6013C5F")]
	[Address(RVA = "0x27D7770", Offset = "0x27D7770", VA = "0x27D7770")]
	public void RequestChummyRequestsList(bool force = false)
	{
	}

	[Token(Token = "0x6013C60")]
	[Address(RVA = "0x27D7A24", Offset = "0x27D7A24", VA = "0x27D7A24")]
	public void OnRequestNtf()
	{
	}

	[Token(Token = "0x6013C61")]
	[Address(RVA = "0x27D7A88", Offset = "0x27D7A88", VA = "0x27D7A88")]
	public void OnConfirmAddingChummyNtf()
	{
	}

	[Token(Token = "0x6013C62")]
	[Address(RVA = "0x27D7AF0", Offset = "0x27D7AF0", VA = "0x27D7AF0")]
	public void OnChummyDismissedNtf(ChummyDismissedNtf ntf)
	{
	}

	[Token(Token = "0x6013C63")]
	[Address(RVA = "0x27D7FB0", Offset = "0x27D7FB0", VA = "0x27D7FB0")]
	public void OnChummyStateChangeNtf(ChummyStateChangeNtf ntf)
	{
	}

	[Token(Token = "0x6013C64")]
	[Address(RVA = "0x27D89D4", Offset = "0x27D89D4", VA = "0x27D89D4")]
	public void OnIntimacyChangeNtf(ChummyIntimacyChangeNtf ntf)
	{
	}

	[Token(Token = "0x6013C65")]
	[Address(RVA = "0x27D4188", Offset = "0x27D4188", VA = "0x27D4188")]
	public MultiRelationTypeInfoDesc GetMultiRelationTypeInfoDesc(proto.EChummy.MultiRelationType type)
	{
		return null;
	}

	[Token(Token = "0x6013C66")]
	[Address(RVA = "0x27D8CEC", Offset = "0x27D8CEC", VA = "0x27D8CEC")]
	public void ProcessCheckingStudentOrMentor(GetAttendanceRes res)
	{
	}

	[Token(Token = "0x6013C67")]
	[Address(RVA = "0x27D9184", Offset = "0x27D9184", VA = "0x27D9184")]
	public void SetStudent()
	{
	}

	[Token(Token = "0x6013C68")]
	[Address(RVA = "0x27D8EEC", Offset = "0x27D8EEC", VA = "0x27D8EEC")]
	public void ProcessChummyState()
	{
	}

	[Token(Token = "0x6013C69")]
	[Address(RVA = "0x27D91EC", Offset = "0x27D91EC", VA = "0x27D91EC")]
	public void ProcessJoinMentoringChannel()
	{
	}

	[Token(Token = "0x6013C6A")]
	[Address(RVA = "0x27D8748", Offset = "0x27D8748", VA = "0x27D8748")]
	public void RemoveRequestFromList(ulong id)
	{
	}

	[Token(Token = "0x6013C6B")]
	[Address(RVA = "0x27CF438", Offset = "0x27CF438", VA = "0x27CF438")]
	public bool CheckMentorApplyPermission()
	{
		return default(bool);
	}

	[Token(Token = "0x6013C6C")]
	[Address(RVA = "0x27D949C", Offset = "0x27D949C", VA = "0x27D949C")]
	public bool IsMentorApplyRankPointAvailable(bool isBR, uint rank)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C6D")]
	[Address(RVA = "0x27D9548", Offset = "0x27D9548", VA = "0x27D9548")]
	public string GetMentorApplyRank(bool isBR)
	{
		return null;
	}

	[Token(Token = "0x6013C6E")]
	[Address(RVA = "0x27D98EC", Offset = "0x27D98EC", VA = "0x27D98EC")]
	public bool IsTrainingCampAvatarOpen(proto.EChummy.MultiRelationType multiRelationType = proto.EChummy.MultiRelationType.MultiRelationType_MENTORING)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C71")]
	[Address(RVA = "0x27D9AAC", Offset = "0x27D9AAC", VA = "0x27D9AAC")]
	public int GetIntimacyMax(proto.EChummy.MultiRelationType relationType, UITrainingCampRole roleState)
	{
		return default(int);
	}

	[Token(Token = "0x6013C72")]
	[Address(RVA = "0x27D9C9C", Offset = "0x27D9C9C", VA = "0x27D9C9C")]
	public List<MultiIntimacyRankAwardDesc> GetIntimacyAwardsDesc(proto.EChummy.MultiRelationType relationType, UITrainingCampRole roleState)
	{
		return null;
	}

	[Token(Token = "0x6013C73")]
	[Address(RVA = "0x27D9EE8", Offset = "0x27D9EE8", VA = "0x27D9EE8")]
	public MultiIntimacyRankAwardDesc GetIntimacyAwardDesc(proto.EChummy.MultiRelationType relationType, proto.EChummy.Role role, uint intimacyRank)
	{
		return null;
	}

	[Token(Token = "0x6013C74")]
	[Address(RVA = "0x27DA07C", Offset = "0x27DA07C", VA = "0x27DA07C")]
	public uint GetBreakUpCountDown(proto.EChummy.MultiRelationType relationType)
	{
		return default(uint);
	}

	[Token(Token = "0x6013C75")]
	[Address(RVA = "0x27DA1D8", Offset = "0x27DA1D8", VA = "0x27DA1D8")]
	public uint GetRejectCountDown(proto.EChummy.MultiRelationType relationType)
	{
		return default(uint);
	}

	[Token(Token = "0x6013C76")]
	[Address(RVA = "0x27DA334", Offset = "0x27DA334", VA = "0x27DA334")]
	public uint GetRelationDisableTime(proto.EChummy.MultiRelationType relationType)
	{
		return default(uint);
	}

	[Token(Token = "0x6013C77")]
	[Address(RVA = "0x27DA490", Offset = "0x27DA490", VA = "0x27DA490")]
	public bool IfAvatarOpen(proto.EChummy.MultiRelationType relationType)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C78")]
	[Address(RVA = "0x27DA5F8", Offset = "0x27DA5F8", VA = "0x27DA5F8")]
	public List<AccountInfoBasic> GetRecommendedMentorList()
	{
		return null;
	}

	[Token(Token = "0x6013C79")]
	[Address(RVA = "0x27DA670", Offset = "0x27DA670", VA = "0x27DA670")]
	public List<AccountInfoBasic> GetRecommendedStudentList()
	{
		return null;
	}

	[Token(Token = "0x6013C7A")]
	[Address(RVA = "0x27DA6E8", Offset = "0x27DA6E8", VA = "0x27DA6E8")]
	public List<ChummyRequest> GetChummyRequests()
	{
		return null;
	}

	[Token(Token = "0x6013C7B")]
	[Address(RVA = "0x27DA9A0", Offset = "0x27DA9A0", VA = "0x27DA9A0")]
	public uint GetStudentIntimacy()
	{
		return default(uint);
	}

	[Token(Token = "0x6013C7C")]
	[Address(RVA = "0x27DAA24", Offset = "0x27DAA24", VA = "0x27DAA24")]
	public uint GetMentorMaxIntimacy()
	{
		return default(uint);
	}

	[Token(Token = "0x6013C7D")]
	[Address(RVA = "0x27DABE4", Offset = "0x27DABE4", VA = "0x27DABE4")]
	public string GetStudentNameById(ulong id)
	{
		return null;
	}

	[Token(Token = "0x6013C7E")]
	[Address(RVA = "0x27DADB4", Offset = "0x27DADB4", VA = "0x27DADB4")]
	public string GetTutorNameById()
	{
		return null;
	}

	[Token(Token = "0x6013C7F")]
	[Address(RVA = "0x27DAEB0", Offset = "0x27DAEB0", VA = "0x27DAEB0")]
	public bool IsTutorAwardAvailable(uint milestone)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C80")]
	[Address(RVA = "0x27D4FC8", Offset = "0x27D4FC8", VA = "0x27D4FC8")]
	public uint GetRankFromMilestone(uint milestone)
	{
		return default(uint);
	}

	[Token(Token = "0x6013C81")]
	[Address(RVA = "0x27D5124", Offset = "0x27D5124", VA = "0x27D5124")]
	public ulong GetClaimAwardStudentChummyId(uint milestone)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013C82")]
	[Address(RVA = "0x27DAF3C", Offset = "0x27DAF3C", VA = "0x27DAF3C")]
	public int TutorAwardAvailableCount(uint milestone)
	{
		return default(int);
	}

	[Token(Token = "0x6013C83")]
	[Address(RVA = "0x27DB2B4", Offset = "0x27DB2B4", VA = "0x27DB2B4")]
	public bool IsStudentAwardReceived(uint milestone)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C84")]
	[Address(RVA = "0x27DB350", Offset = "0x27DB350", VA = "0x27DB350")]
	public bool IsStudentAwardClaimed(uint milestone)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C85")]
	[Address(RVA = "0x27DB4EC", Offset = "0x27DB4EC", VA = "0x27DB4EC")]
	public AccountInfoBasic GetClassmate(int index)
	{
		return null;
	}

	[Token(Token = "0x6013C86")]
	[Address(RVA = "0x27DB638", Offset = "0x27DB638", VA = "0x27DB638")]
	public void ProcessMentorTitle(List<MentorTitleData> list)
	{
	}

	[Token(Token = "0x6013C87")]
	[Address(RVA = "0x27DB698", Offset = "0x27DB698", VA = "0x27DB698")]
	public int GetMentorLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6013C88")]
	[Address(RVA = "0x27DB888", Offset = "0x27DB888", VA = "0x27DB888")]
	public string GetMentorTitle()
	{
		return null;
	}

	[Token(Token = "0x6013C89")]
	[Address(RVA = "0x27DBAB0", Offset = "0x27DBAB0", VA = "0x27DBAB0")]
	public bool IsRevokeDismissAvailable(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013C8A")]
	[Address(RVA = "0x27D552C", Offset = "0x27D552C", VA = "0x27D552C")]
	public ulong GetMentorId()
	{
		return default(ulong);
	}

	[Token(Token = "0x6013C8B")]
	[Address(RVA = "0x27DBD68", Offset = "0x27DBD68", VA = "0x27DBD68")]
	public List<ulong> GetStudentId()
	{
		return null;
	}

	[Token(Token = "0x6013C8C")]
	[Address(RVA = "0x27DBF80", Offset = "0x27DBF80", VA = "0x27DBF80")]
	public void CheckAutoDismiss()
	{
	}

	[Token(Token = "0x6013C8D")]
	[Address(RVA = "0x27DC124", Offset = "0x27DC124", VA = "0x27DC124")]
	private void _003CRequestChummyDesc_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013C8E")]
	[Address(RVA = "0x27DC250", Offset = "0x27DC250", VA = "0x27DC250")]
	private void _003CRequestChummyIntimacyAwardInfo_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013C8F")]
	[Address(RVA = "0x27DC380", Offset = "0x27DC380", VA = "0x27DC380")]
	private void _003CRequestGetChummyState_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013C90")]
	[Address(RVA = "0x27DC4BC", Offset = "0x27DC4BC", VA = "0x27DC4BC")]
	private void _003CRequestApplyForTutor_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013C91")]
	[Address(RVA = "0x27DC598", Offset = "0x27DC598", VA = "0x27DC598")]
	private void _003CRequestRecommendedMentorList_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013C92")]
	[Address(RVA = "0x27DC6CC", Offset = "0x27DC6CC", VA = "0x27DC6CC")]
	private void _003CRequestRecommendedStudentList_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013C93")]
	[Address(RVA = "0x27DC800", Offset = "0x27DC800", VA = "0x27DC800")]
	private void _003CRequestCallbackDismissChummy_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013C94")]
	[Address(RVA = "0x27DC814", Offset = "0x27DC814", VA = "0x27DC814")]
	private void _003CRequestChummyRequestsList_003Em__7(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013C95")]
	[Address(RVA = "0x27DCA00", Offset = "0x27DCA00", VA = "0x27DCA00")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
