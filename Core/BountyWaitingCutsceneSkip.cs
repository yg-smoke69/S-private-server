using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000442")]
public class BountyWaitingCutsceneSkip : MonoBehaviour
{
	[Token(Token = "0x4003C23")]
	[FieldOffset(Offset = "0xC")]
	public float BeginTime;

	[Token(Token = "0x4003C24")]
	[FieldOffset(Offset = "0x10")]
	public float ShowDuration;

	[Token(Token = "0x4003C25")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ShowRoot;

	[Token(Token = "0x4003C26")]
	[FieldOffset(Offset = "0x18")]
	private float m_ActiveTime;

	[Token(Token = "0x4003C27")]
	[FieldOffset(Offset = "0x1C")]
	private float m_ShowedTime;

	[Token(Token = "0x4003C28")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsClosed;

	[Token(Token = "0x600154E")]
	[Address(RVA = "0x14B44BC", Offset = "0x14B44BC", VA = "0x14B44BC")]
	public BountyWaitingCutsceneSkip()
	{
	}

	[Token(Token = "0x600154F")]
	[Address(RVA = "0x14B44C4", Offset = "0x14B44C4", VA = "0x14B44C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001550")]
	[Address(RVA = "0x14B44F4", Offset = "0x14B44F4", VA = "0x14B44F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001551")]
	[Address(RVA = "0x14B4518", Offset = "0x14B4518", VA = "0x14B4518")]
	private void Update()
	{
	}

	[Token(Token = "0x6001552")]
	[Address(RVA = "0x14B4634", Offset = "0x14B4634", VA = "0x14B4634")]
	public void SkipCutscene()
	{
	}
}
