using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B5E")]
public class HangDebug : MonoBehaviour
{
	[Token(Token = "0x40194A5")]
	[FieldOffset(Offset = "0xC")]
	public GameObject CharaObj;

	[Token(Token = "0x40194A6")]
	[FieldOffset(Offset = "0x10")]
	public int FpsLimit;

	[Token(Token = "0x40194A7")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 WindDirection;

	[Token(Token = "0x40194A8")]
	[FieldOffset(Offset = "0x20")]
	public float WindPower;

	[Token(Token = "0x40194A9")]
	[FieldOffset(Offset = "0x24")]
	private GUIStyle s_GuiStyle;

	[Token(Token = "0x40194AA")]
	[FieldOffset(Offset = "0x28")]
	private GUIStyleState s_StyleState;

	[Token(Token = "0x40194AB")]
	[FieldOffset(Offset = "0x2C")]
	private HangManager script_HangManager;

	[Token(Token = "0x40194AC")]
	[FieldOffset(Offset = "0x30")]
	private bool WindState;

	[Token(Token = "0x40194AD")]
	[FieldOffset(Offset = "0x0")]
	private static float FpsAccuracy;

	[Token(Token = "0x40194AE")]
	[FieldOffset(Offset = "0x4")]
	private static int FpsFrameCount;

	[Token(Token = "0x40194AF")]
	[FieldOffset(Offset = "0x8")]
	private static float FpsElapsedTime;

	[Token(Token = "0x6017A3A")]
	[Address(RVA = "0x350EC14", Offset = "0x350EC14", VA = "0x350EC14")]
	public HangDebug()
	{
	}

	[Token(Token = "0x6017A3B")]
	[Address(RVA = "0x350EC80", Offset = "0x350EC80", VA = "0x350EC80")]
	public static int FpsCalc()
	{
		return default(int);
	}

	[Token(Token = "0x6017A3C")]
	[Address(RVA = "0x350EE08", Offset = "0x350EE08", VA = "0x350EE08")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017A3D")]
	[Address(RVA = "0x350F004", Offset = "0x350F004", VA = "0x350F004")]
	private void Start()
	{
	}

	[Token(Token = "0x6017A3E")]
	[Address(RVA = "0x350F188", Offset = "0x350F188", VA = "0x350F188")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6017A3F")]
	[Address(RVA = "0x350F39C", Offset = "0x350F39C", VA = "0x350F39C")]
	private void Update()
	{
	}
}
