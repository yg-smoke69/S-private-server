using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003AC6")]
public class DummyTask : BaseTask
{
	[Token(Token = "0x4018F97")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar progressBar;

	[Token(Token = "0x4018F98")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton completeButton;

	[Token(Token = "0x4018F99")]
	[FieldOffset(Offset = "0x50")]
	public float completeTime;

	[Token(Token = "0x4018F9A")]
	[FieldOffset(Offset = "0x54")]
	private float m_CurTime;

	[Token(Token = "0x601745F")]
	[Address(RVA = "0x1C980D0", Offset = "0x1C980D0", VA = "0x1C980D0")]
	public DummyTask()
	{
	}

	[Token(Token = "0x6017460")]
	[Address(RVA = "0x1C980E4", Offset = "0x1C980E4", VA = "0x1C980E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017461")]
	[Address(RVA = "0x1C98248", Offset = "0x1C98248", VA = "0x1C98248", Slot = "4")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x6017462")]
	[Address(RVA = "0x1C982B4", Offset = "0x1C982B4", VA = "0x1C982B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6017463")]
	[Address(RVA = "0x1C983DC", Offset = "0x1C983DC", VA = "0x1C983DC")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
