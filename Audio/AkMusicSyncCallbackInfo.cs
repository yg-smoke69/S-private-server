using System;
using Il2CppDummyDll;

[Token(Token = "0x2003D92")]
public class AkMusicSyncCallbackInfo : AkCallbackInfo
{
	[Token(Token = "0x401A2E5")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr swigCPtr;

	[Token(Token = "0x17001ABC")]
	public uint playingID
	{
		[Token(Token = "0x6019095")]
		[Address(RVA = "0x36BADEC", Offset = "0x36BADEC", VA = "0x36BADEC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001ABD")]
	public int segmentInfo_iCurrentPosition
	{
		[Token(Token = "0x6019096")]
		[Address(RVA = "0x36BAE74", Offset = "0x36BAE74", VA = "0x36BAE74")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001ABE")]
	public int segmentInfo_iPreEntryDuration
	{
		[Token(Token = "0x6019097")]
		[Address(RVA = "0x36BAEFC", Offset = "0x36BAEFC", VA = "0x36BAEFC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001ABF")]
	public int segmentInfo_iActiveDuration
	{
		[Token(Token = "0x6019098")]
		[Address(RVA = "0x36BAF84", Offset = "0x36BAF84", VA = "0x36BAF84")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001AC0")]
	public int segmentInfo_iPostExitDuration
	{
		[Token(Token = "0x6019099")]
		[Address(RVA = "0x36BB00C", Offset = "0x36BB00C", VA = "0x36BB00C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001AC1")]
	public int segmentInfo_iRemainingLookAheadTime
	{
		[Token(Token = "0x601909A")]
		[Address(RVA = "0x36BB094", Offset = "0x36BB094", VA = "0x36BB094")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001AC2")]
	public float segmentInfo_fBeatDuration
	{
		[Token(Token = "0x601909B")]
		[Address(RVA = "0x36BB11C", Offset = "0x36BB11C", VA = "0x36BB11C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001AC3")]
	public float segmentInfo_fBarDuration
	{
		[Token(Token = "0x601909C")]
		[Address(RVA = "0x36BB1A4", Offset = "0x36BB1A4", VA = "0x36BB1A4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001AC4")]
	public float segmentInfo_fGridDuration
	{
		[Token(Token = "0x601909D")]
		[Address(RVA = "0x36BB22C", Offset = "0x36BB22C", VA = "0x36BB22C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001AC5")]
	public float segmentInfo_fGridOffset
	{
		[Token(Token = "0x601909E")]
		[Address(RVA = "0x36BB2B4", Offset = "0x36BB2B4", VA = "0x36BB2B4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001AC6")]
	public AkCallbackType musicSyncType
	{
		[Token(Token = "0x601909F")]
		[Address(RVA = "0x36BB33C", Offset = "0x36BB33C", VA = "0x36BB33C")]
		get
		{
			return default(AkCallbackType);
		}
	}

	[Token(Token = "0x17001AC7")]
	public string userCueName
	{
		[Token(Token = "0x60190A0")]
		[Address(RVA = "0x36BB3C4", Offset = "0x36BB3C4", VA = "0x36BB3C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601908F")]
	[Address(RVA = "0x36BAA18", Offset = "0x36BAA18", VA = "0x36BAA18")]
	internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6019090")]
	[Address(RVA = "0x36BAABC", Offset = "0x36BAABC", VA = "0x36BAABC")]
	public AkMusicSyncCallbackInfo()
	{
	}

	[Token(Token = "0x6019091")]
	[Address(RVA = "0x36BAB4C", Offset = "0x36BAB4C", VA = "0x36BAB4C")]
	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6019092")]
	[Address(RVA = "0x36BABA4", Offset = "0x36BABA4", VA = "0x36BABA4", Slot = "5")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6019093")]
	[Address(RVA = "0x36BAC40", Offset = "0x36BAC40", VA = "0x36BAC40", Slot = "1")]
	~AkMusicSyncCallbackInfo()
	{
	}

	[Token(Token = "0x6019094")]
	[Address(RVA = "0x36BACB4", Offset = "0x36BACB4", VA = "0x36BACB4", Slot = "6")]
	public override void Dispose()
	{
	}
}
