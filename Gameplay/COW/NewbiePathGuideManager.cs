using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DFE")]
internal class NewbiePathGuideManager : SingletonModule<NewbiePathGuideManager>
{
	[Token(Token = "0x4011A05")]
	[FieldOffset(Offset = "0xC")]
	private int _003CGuideProgress_003Ek__BackingField;

	[Token(Token = "0x4011A06")]
	[FieldOffset(Offset = "0x10")]
	private ENewbieGuideType _003CCurNewbieGuideType_003Ek__BackingField;

	[Token(Token = "0x4011A07")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<int, string[]> m_GuideTips;

	[Token(Token = "0x170013F7")]
	public bool InGuideProgress
	{
		[Token(Token = "0x601345A")]
		[Address(RVA = "0x28B9A2C", Offset = "0x28B9A2C", VA = "0x28B9A2C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170013F8")]
	public int GuideProgress
	{
		[Token(Token = "0x601345C")]
		[Address(RVA = "0x28B9A98", Offset = "0x28B9A98", VA = "0x28B9A98")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601345B")]
		[Address(RVA = "0x28B9AA0", Offset = "0x28B9AA0", VA = "0x28B9AA0")]
		private set
		{
		}
	}

	[Token(Token = "0x170013F9")]
	public ENewbieGuideType CurNewbieGuideType
	{
		[Token(Token = "0x601345E")]
		[Address(RVA = "0x28B9AB0", Offset = "0x28B9AB0", VA = "0x28B9AB0")]
		get
		{
			return default(ENewbieGuideType);
		}
		[Token(Token = "0x601345D")]
		[Address(RVA = "0x28B9AA8", Offset = "0x28B9AA8", VA = "0x28B9AA8")]
		private set
		{
		}
	}

	[Token(Token = "0x6013459")]
	[Address(RVA = "0x28B84EC", Offset = "0x28B84EC", VA = "0x28B84EC")]
	public NewbiePathGuideManager()
	{
	}

	[Token(Token = "0x601345F")]
	[Address(RVA = "0x28B9AB8", Offset = "0x28B9AB8", VA = "0x28B9AB8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013460")]
	[Address(RVA = "0x28B9B14", Offset = "0x28B9B14", VA = "0x28B9B14", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013461")]
	[Address(RVA = "0x28B9B68", Offset = "0x28B9B68", VA = "0x28B9B68")]
	public int GetTotalGuideSteps(ENewbieGuideType type)
	{
		return default(int);
	}

	[Token(Token = "0x6013462")]
	[Address(RVA = "0x28B0ED0", Offset = "0x28B0ED0", VA = "0x28B0ED0")]
	public string GetCurGuideTips()
	{
		return null;
	}

	[Token(Token = "0x6013463")]
	[Address(RVA = "0x28B9C74", Offset = "0x28B9C74", VA = "0x28B9C74")]
	public void StartGuide(object[] param)
	{
	}

	[Token(Token = "0x6013464")]
	[Address(RVA = "0x28BA184", Offset = "0x28BA184", VA = "0x28BA184")]
	public void BoostCurGuideProgress()
	{
	}

	[Token(Token = "0x6013465")]
	[Address(RVA = "0x28BA200", Offset = "0x28BA200", VA = "0x28BA200")]
	public void ForceStopAllGuide()
	{
	}

	[Token(Token = "0x6013466")]
	[Address(RVA = "0x28B9DA0", Offset = "0x28B9DA0", VA = "0x28B9DA0")]
	public void SetGuideProgress(ENewbieGuideType type, int value, int ctdvalue = -1)
	{
	}

	[Token(Token = "0x6013467")]
	[Address(RVA = "0x28BA278", Offset = "0x28BA278", VA = "0x28BA278")]
	private void StopOldGuide()
	{
	}
}
