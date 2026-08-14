using Il2CppDummyDll;
using UnityEngine;

namespace COW.ECAModeDev;

[Token(Token = "0x20002CF")]
public class ModeTestStartup : MonoBehaviour
{
	[Token(Token = "0x4003306")]
	[FieldOffset(Offset = "0xC")]
	public ECASystem ECALevel;

	[Token(Token = "0x4003307")]
	[FieldOffset(Offset = "0x10")]
	public uint m_MapID;

	[Token(Token = "0x4003308")]
	[FieldOffset(Offset = "0x14")]
	public uint m_ModeID;

	[Token(Token = "0x4003309")]
	[FieldOffset(Offset = "0x18")]
	public bool SingleplayerGame;

	[Token(Token = "0x400330A")]
	[FieldOffset(Offset = "0x0")]
	public static ModeTestStartup instance;

	[Token(Token = "0x400330B")]
	[FieldOffset(Offset = "0x1C")]
	private ECAModeDevGameEntry m_MainEntry;

	[Token(Token = "0x400330C")]
	[FieldOffset(Offset = "0x20")]
	private readonly string[] DONT_DESTROY_RESOURCES;

	[Token(Token = "0x400330D")]
	[FieldOffset(Offset = "0x4")]
	private static OnLogCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x1C99AA0", Offset = "0x1C99AA0", VA = "0x1C99AA0")]
	public ModeTestStartup()
	{
	}

	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x1C99B94", Offset = "0x1C99B94", VA = "0x1C99B94")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x1C99EEC", Offset = "0x1C99EEC", VA = "0x1C99EEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x1C99EF0", Offset = "0x1C99EF0", VA = "0x1C99EF0")]
	private void StartGame()
	{
	}

	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x1C9A468", Offset = "0x1C9A468", VA = "0x1C9A468")]
	public void SetModeAndMap(uint modeid, uint mapid)
	{
	}

	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x1C9A478", Offset = "0x1C9A478", VA = "0x1C9A478")]
	private static void _003CAwake_003Em__0(DebugLogType logType, string content)
	{
	}
}
