using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023F0")]
public class TutorialManager : SingletonModule<TutorialManager>
{
	[Token(Token = "0x400E00B")]
	private const string TutorialKey = "TutorialStep";

	[Token(Token = "0x400E00C")]
	[FieldOffset(Offset = "0xC")]
	private List<long> m_TutorialStepFlag;

	[Token(Token = "0x400E00D")]
	[FieldOffset(Offset = "0x10")]
	private List<long> m_TutorialStepFlag_ThisLauncher;

	[Token(Token = "0x400E00E")]
	[FieldOffset(Offset = "0x14")]
	private int stepFlagCount;

	[Token(Token = "0x400E00F")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, TutorialSetting> m_TutSettings;

	[Token(Token = "0x400E010")]
	[FieldOffset(Offset = "0x1C")]
	private UITutorialIndicatorController m_TutController;

	[Token(Token = "0x400E011")]
	[FieldOffset(Offset = "0x20")]
	public TutorialVariant variant;

	[Token(Token = "0x400E012")]
	[FieldOffset(Offset = "0x24")]
	private bool isNewbiePlayer;

	[Token(Token = "0x400E013")]
	[FieldOffset(Offset = "0x28")]
	private TutorialEventEnum m_CurTutorial;

	[Token(Token = "0x400E014")]
	[FieldOffset(Offset = "0x2C")]
	private uint delayCallId;

	[Token(Token = "0x400E015")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IgnoreNewbieChoice;

	[Token(Token = "0x600CAB7")]
	[Address(RVA = "0x23302B4", Offset = "0x23302B4", VA = "0x23302B4")]
	public TutorialManager()
	{
	}

	[Token(Token = "0x600CAB8")]
	[Address(RVA = "0x2330344", Offset = "0x2330344", VA = "0x2330344")]
	public TutorialEventEnum CurrentTutorialType()
	{
		return default(TutorialEventEnum);
	}

	[Token(Token = "0x600CAB9")]
	[Address(RVA = "0x233039C", Offset = "0x233039C", VA = "0x233039C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600CABA")]
	[Address(RVA = "0x23309B4", Offset = "0x23309B4", VA = "0x23309B4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600CABB")]
	[Address(RVA = "0x2330630", Offset = "0x2330630", VA = "0x2330630")]
	private void InitTutorialSettings()
	{
	}

	[Token(Token = "0x600CABC")]
	[Address(RVA = "0x2330BCC", Offset = "0x2330BCC", VA = "0x2330BCC")]
	public void Stop(TutorialEventEnum type = TutorialEventEnum.TutorialEventMax, bool noNeedCheckNextTuto = false, TutorialCloseType closeType = TutorialCloseType.None)
	{
	}

	[Token(Token = "0x600CABD")]
	[Address(RVA = "0x2332FA0", Offset = "0x2332FA0", VA = "0x2332FA0")]
	private void StopLast()
	{
	}

	[Token(Token = "0x600CABE")]
	[Address(RVA = "0x2330E10", Offset = "0x2330E10", VA = "0x2330E10")]
	private bool CheckAndShowNextTuto(TutorialEventEnum type)
	{
		return default(bool);
	}

	[Token(Token = "0x600CABF")]
	[Address(RVA = "0x2333ED8", Offset = "0x2333ED8", VA = "0x2333ED8")]
	public void SetReinstallEffective()
	{
	}

	[Token(Token = "0x600CAC0")]
	[Address(RVA = "0x2334010", Offset = "0x2334010", VA = "0x2334010")]
	public bool IsFinished(TutorialEventEnum eventType)
	{
		return default(bool);
	}

	[Token(Token = "0x600CAC1")]
	[Address(RVA = "0x23341A0", Offset = "0x23341A0", VA = "0x23341A0")]
	public bool IsNew(TutorialEventEnum eventType)
	{
		return default(bool);
	}

	[Token(Token = "0x600CAC2")]
	[Address(RVA = "0x23342B0", Offset = "0x23342B0", VA = "0x23342B0")]
	public void SetTutorialFinish(TutorialEventEnum eventType)
	{
	}

	[Token(Token = "0x600CAC3")]
	[Address(RVA = "0x23345FC", Offset = "0x23345FC", VA = "0x23345FC")]
	public void SetAllTutorialFinish()
	{
	}

	[Token(Token = "0x600CAC4")]
	[Address(RVA = "0x2334874", Offset = "0x2334874", VA = "0x2334874")]
	public void ResetAllTutorial()
	{
	}

	[Token(Token = "0x600CAC5")]
	[Address(RVA = "0x2334AEC", Offset = "0x2334AEC", VA = "0x2334AEC")]
	public void IgnoreCheckNewbie(bool ignore)
	{
	}

	[Token(Token = "0x600CAC6")]
	[Address(RVA = "0x2333020", Offset = "0x2333020", VA = "0x2333020")]
	public bool ShowTutorial(TutorialEventEnum eventType, [Optional] UIButton bindBtn, [Optional] UIWidget bindWidget, bool alwaysShow = false, bool isForceClickComplete = false, bool isMaskAll = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600CAC7")]
	[Address(RVA = "0x2334B4C", Offset = "0x2334B4C", VA = "0x2334B4C")]
	public void SetTutorialParams(TutorialEventEnum eventType, string param)
	{
	}

	[Token(Token = "0x600CAC8")]
	[Address(RVA = "0x2334C5C", Offset = "0x2334C5C", VA = "0x2334C5C")]
	public void RefreshTutorialPosition(Transform showTrans)
	{
	}

	[Token(Token = "0x600CAC9")]
	[Address(RVA = "0x2334DA8", Offset = "0x2334DA8", VA = "0x2334DA8")]
	public void RefreshTutorialWholePosition(Transform showTrans)
	{
	}

	[Token(Token = "0x600CACA")]
	[Address(RVA = "0x2333808", Offset = "0x2333808", VA = "0x2333808")]
	public bool CanShowTutorial(TutorialEventEnum eventType)
	{
		return default(bool);
	}

	[Token(Token = "0x600CACB")]
	[Address(RVA = "0x2334EF0", Offset = "0x2334EF0", VA = "0x2334EF0")]
	public void StopClimb()
	{
	}

	[Token(Token = "0x600CACC")]
	[Address(RVA = "0x2334F68", Offset = "0x2334F68", VA = "0x2334F68")]
	public float GetDuration(TutorialEventEnum eventType)
	{
		return default(float);
	}
}
