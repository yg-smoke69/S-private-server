using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A29")]
public class PreviewCameraMove : PreviewBaseComponent
{
	[Token(Token = "0x4005B18")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 DEFAULTSTRARPOS;

	[Token(Token = "0x4005B19")]
	[FieldOffset(Offset = "0xC")]
	public static Vector3 DEFAULTENDPOS;

	[Token(Token = "0x4005B1A")]
	[FieldOffset(Offset = "0x10")]
	protected float m_Movetime;

	[Token(Token = "0x4005B1B")]
	[FieldOffset(Offset = "0x14")]
	protected bool movedir;

	[Token(Token = "0x4005B1C")]
	[FieldOffset(Offset = "0x15")]
	protected bool cameramove;

	[Token(Token = "0x4005B1D")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 startPos;

	[Token(Token = "0x4005B1E")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 middelePos;

	[Token(Token = "0x4005B1F")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 endPos;

	[Token(Token = "0x4005B20")]
	[FieldOffset(Offset = "0x3C")]
	public float movetime;

	[Token(Token = "0x4005B21")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 startAngle;

	[Token(Token = "0x4005B22")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_CurrentPos;

	[Token(Token = "0x4005B23")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 lerpstart;

	[Token(Token = "0x4005B24")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 lerpend;

	[Token(Token = "0x4005B25")]
	[FieldOffset(Offset = "0x70")]
	private float lerpbgstart;

	[Token(Token = "0x4005B26")]
	[FieldOffset(Offset = "0x74")]
	private float lerpbgend;

	[Token(Token = "0x4005B27")]
	[FieldOffset(Offset = "0x78")]
	private float lerpbgcurrent;

	[Token(Token = "0x4005B28")]
	[FieldOffset(Offset = "0x7C")]
	private GameObject BgObj;

	[Token(Token = "0x4005B29")]
	[FieldOffset(Offset = "0x80")]
	private float currentmovetime;

	[Token(Token = "0x6004F53")]
	[Address(RVA = "0x1C13180", Offset = "0x1C13180", VA = "0x1C13180")]
	public PreviewCameraMove()
	{
	}

	[Token(Token = "0x6004F54")]
	[Address(RVA = "0x1C188FC", Offset = "0x1C188FC", VA = "0x1C188FC")]
	public void SetLerpBgObj(GameObject obj)
	{
	}

	[Token(Token = "0x6004F55")]
	[Address(RVA = "0x1C1895C", Offset = "0x1C1895C", VA = "0x1C1895C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004F56")]
	[Address(RVA = "0x1C18A04", Offset = "0x1C18A04", VA = "0x1C18A04")]
	public void SavePos()
	{
	}

	[Token(Token = "0x6004F57")]
	[Address(RVA = "0x1C18AA4", Offset = "0x1C18AA4", VA = "0x1C18AA4")]
	public void ResumePos()
	{
	}

	[Token(Token = "0x6004F58")]
	[Address(RVA = "0x1C18B50", Offset = "0x1C18B50", VA = "0x1C18B50")]
	public void SetCameraStartPos()
	{
	}

	[Token(Token = "0x6004F59")]
	[Address(RVA = "0x1C18BFC", Offset = "0x1C18BFC", VA = "0x1C18BFC")]
	public bool CheckCanClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6004F5A")]
	[Address(RVA = "0x1C18CF8", Offset = "0x1C18CF8", VA = "0x1C18CF8")]
	public void SetEnable(bool dir)
	{
	}

	[Token(Token = "0x6004F5B")]
	[Address(RVA = "0x1C18F14", Offset = "0x1C18F14", VA = "0x1C18F14")]
	public void SetMiddlePos(Vector3 pos)
	{
	}

	[Token(Token = "0x6004F5C")]
	[Address(RVA = "0x1C18F9C", Offset = "0x1C18F9C", VA = "0x1C18F9C")]
	public void SetEndPos(Vector3 pos)
	{
	}

	[Token(Token = "0x6004F5D")]
	[Address(RVA = "0x1C19024", Offset = "0x1C19024", VA = "0x1C19024")]
	public void SetStartPos(Vector3 pos)
	{
	}

	[Token(Token = "0x6004F5E")]
	[Address(RVA = "0x1C190AC", Offset = "0x1C190AC", VA = "0x1C190AC")]
	public void SetStartAngle(Vector3 angle)
	{
	}

	[Token(Token = "0x6004F5F")]
	[Address(RVA = "0x1C19134", Offset = "0x1C19134", VA = "0x1C19134")]
	public void SetMoveTime(float time)
	{
	}

	[Token(Token = "0x6004F60")]
	[Address(RVA = "0x1C191A0", Offset = "0x1C191A0", VA = "0x1C191A0")]
	public void InitLerpEndPos(Vector3 pos)
	{
	}

	[Token(Token = "0x6004F61")]
	[Address(RVA = "0x1C19228", Offset = "0x1C19228", VA = "0x1C19228")]
	public void ResetCameraTrans()
	{
	}

	[Token(Token = "0x6004F62")]
	[Address(RVA = "0x1C19484", Offset = "0x1C19484", VA = "0x1C19484")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004F63")]
	[Address(RVA = "0x1C195EC", Offset = "0x1C195EC", VA = "0x1C195EC")]
	public void FocusBg()
	{
	}

	[Token(Token = "0x6004F64")]
	[Address(RVA = "0x1C19734", Offset = "0x1C19734", VA = "0x1C19734")]
	private void Update()
	{
	}
}
