using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003ACA")]
public class TaskBlend : BaseTask
{
	[Token(Token = "0x4018FA8")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar progressBar;

	[Token(Token = "0x4018FA9")]
	[FieldOffset(Offset = "0x4C")]
	public UIProgressBar progressBarLeft;

	[Token(Token = "0x4018FAA")]
	[FieldOffset(Offset = "0x50")]
	public UIProgressBar progressBarRight;

	[Token(Token = "0x4018FAB")]
	[FieldOffset(Offset = "0x54")]
	public UICustomHoverButton pressButtonLeft;

	[Token(Token = "0x4018FAC")]
	[FieldOffset(Offset = "0x58")]
	public UICustomHoverButton pressButtonRight;

	[Token(Token = "0x4018FAD")]
	[FieldOffset(Offset = "0x5C")]
	public float completeTime;

	[Token(Token = "0x4018FAE")]
	[FieldOffset(Offset = "0x60")]
	private float m_CurLeftTime;

	[Token(Token = "0x4018FAF")]
	[FieldOffset(Offset = "0x64")]
	private float m_CurRightTime;

	[Token(Token = "0x4018FB0")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsLeftRun;

	[Token(Token = "0x4018FB1")]
	[FieldOffset(Offset = "0x69")]
	private bool m_IsRightRun;

	[Token(Token = "0x4018FB2")]
	[FieldOffset(Offset = "0x6A")]
	private bool m_IsComplete;

	[Token(Token = "0x601747B")]
	[Address(RVA = "0x2895CE0", Offset = "0x2895CE0", VA = "0x2895CE0")]
	public TaskBlend()
	{
	}

	[Token(Token = "0x601747C")]
	[Address(RVA = "0x2895CF4", Offset = "0x2895CF4", VA = "0x2895CF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x601747D")]
	[Address(RVA = "0x2895E58", Offset = "0x2895E58", VA = "0x2895E58", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x601747E")]
	[Address(RVA = "0x2895F40", Offset = "0x2895F40", VA = "0x2895F40")]
	private void OnPressLeft(bool isPress)
	{
	}

	[Token(Token = "0x601747F")]
	[Address(RVA = "0x2895FA0", Offset = "0x2895FA0", VA = "0x2895FA0")]
	private void OnPressRight(bool isPress)
	{
	}

	[Token(Token = "0x6017480")]
	[Address(RVA = "0x2896000", Offset = "0x2896000", VA = "0x2896000")]
	private void CheckComplete()
	{
	}

	[Token(Token = "0x6017481")]
	[Address(RVA = "0x28960C8", Offset = "0x28960C8", VA = "0x28960C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6017482")]
	[Address(RVA = "0x28962B8", Offset = "0x28962B8", VA = "0x28962B8")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
