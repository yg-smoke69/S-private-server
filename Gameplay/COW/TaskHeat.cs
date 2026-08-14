using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003ACF")]
public class TaskHeat : BaseTask
{
	[Token(Token = "0x4018FCE")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar progressBar;

	[Token(Token = "0x4018FCF")]
	[FieldOffset(Offset = "0x4C")]
	public UIProgressBar targetBarLeft;

	[Token(Token = "0x4018FD0")]
	[FieldOffset(Offset = "0x50")]
	public UIProgressBar targetBarRight;

	[Token(Token = "0x4018FD1")]
	[FieldOffset(Offset = "0x54")]
	public UICustomHoverButton pressButton;

	[Token(Token = "0x4018FD2")]
	[FieldOffset(Offset = "0x58")]
	public bool clickStop;

	[Token(Token = "0x4018FD3")]
	[FieldOffset(Offset = "0x59")]
	public bool pingpong;

	[Token(Token = "0x4018FD4")]
	[FieldOffset(Offset = "0x5C")]
	public float leftRange;

	[Token(Token = "0x4018FD5")]
	[FieldOffset(Offset = "0x60")]
	public float targetRange;

	[Token(Token = "0x4018FD6")]
	[FieldOffset(Offset = "0x64")]
	public float completeTime;

	[Token(Token = "0x4018FD7")]
	[FieldOffset(Offset = "0x68")]
	private float m_CurTime;

	[Token(Token = "0x4018FD8")]
	[FieldOffset(Offset = "0x6C")]
	private float m_TargetValue;

	[Token(Token = "0x4018FD9")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsRun;

	[Token(Token = "0x4018FDA")]
	[FieldOffset(Offset = "0x74")]
	private int m_Dir;

	[Token(Token = "0x601749A")]
	[Address(RVA = "0x28980C4", Offset = "0x28980C4", VA = "0x28980C4")]
	public TaskHeat()
	{
	}

	[Token(Token = "0x601749B")]
	[Address(RVA = "0x28980F4", Offset = "0x28980F4", VA = "0x28980F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x601749C")]
	[Address(RVA = "0x289829C", Offset = "0x289829C", VA = "0x289829C", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x601749D")]
	[Address(RVA = "0x2898430", Offset = "0x2898430", VA = "0x2898430")]
	private void OnPress(bool isPress)
	{
	}

	[Token(Token = "0x601749E")]
	[Address(RVA = "0x2898628", Offset = "0x2898628", VA = "0x2898628")]
	private void OnClick()
	{
	}

	[Token(Token = "0x601749F")]
	[Address(RVA = "0x28984B4", Offset = "0x28984B4", VA = "0x28984B4")]
	private void CheckComplete()
	{
	}

	[Token(Token = "0x60174A0")]
	[Address(RVA = "0x2898690", Offset = "0x2898690", VA = "0x2898690", Slot = "6")]
	public override void OnFailure()
	{
	}

	[Token(Token = "0x60174A1")]
	[Address(RVA = "0x2898708", Offset = "0x2898708", VA = "0x2898708", Slot = "9")]
	public override void Resume()
	{
	}

	[Token(Token = "0x60174A2")]
	[Address(RVA = "0x2898778", Offset = "0x2898778", VA = "0x2898778", Slot = "8")]
	public override void Pause()
	{
	}

	[Token(Token = "0x60174A3")]
	[Address(RVA = "0x28987E8", Offset = "0x28987E8", VA = "0x28987E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60174A4")]
	[Address(RVA = "0x2898914", Offset = "0x2898914", VA = "0x2898914")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x60174A5")]
	[Address(RVA = "0x289891C", Offset = "0x289891C", VA = "0x289891C")]
	public void _003C_003EiFixBaseProxy_OnFailure()
	{
	}

	[Token(Token = "0x60174A6")]
	[Address(RVA = "0x2898924", Offset = "0x2898924", VA = "0x2898924")]
	public void _003C_003EiFixBaseProxy_Resume()
	{
	}

	[Token(Token = "0x60174A7")]
	[Address(RVA = "0x289892C", Offset = "0x289892C", VA = "0x289892C")]
	public void _003C_003EiFixBaseProxy_Pause()
	{
	}
}
