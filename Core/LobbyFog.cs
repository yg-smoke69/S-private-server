using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x2003F72")]
public class LobbyFog : MonoBehaviour
{
	[Token(Token = "0x401ABFC")]
	[FieldOffset(Offset = "0x0")]
	protected static int _FogColor1;

	[Token(Token = "0x401ABFD")]
	[FieldOffset(Offset = "0x4")]
	protected static int _FogColor2;

	[Token(Token = "0x401ABFE")]
	[FieldOffset(Offset = "0x8")]
	protected static int _FogColor3;

	[Token(Token = "0x401ABFF")]
	[FieldOffset(Offset = "0xC")]
	protected static int _FogColor4;

	[Token(Token = "0x401AC00")]
	[FieldOffset(Offset = "0x10")]
	protected static int _FogLerp1234;

	[Token(Token = "0x401AC01")]
	[FieldOffset(Offset = "0x14")]
	protected static int _FogLerp23StartEnd;

	[Token(Token = "0x401AC02")]
	[FieldOffset(Offset = "0x18")]
	protected static int _FogCenter;

	[Token(Token = "0x401AC03")]
	[FieldOffset(Offset = "0x1C")]
	protected static int _FogEllipse;

	[Token(Token = "0x401AC04")]
	[FieldOffset(Offset = "0xC")]
	public Color color1;

	[Token(Token = "0x401AC05")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 lerp12;

	[Token(Token = "0x401AC06")]
	[FieldOffset(Offset = "0x24")]
	public Color color2;

	[Token(Token = "0x401AC07")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 lerp23;

	[Token(Token = "0x401AC08")]
	[FieldOffset(Offset = "0x3C")]
	public Color color3;

	[Token(Token = "0x401AC09")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 lerp34;

	[Token(Token = "0x401AC0A")]
	[FieldOffset(Offset = "0x54")]
	public Color color4;

	[Token(Token = "0x401AC0B")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 startEnd;

	[Token(Token = "0x401AC0C")]
	[FieldOffset(Offset = "0x6C")]
	protected Vector4 mLerp1234;

	[Token(Token = "0x401AC0D")]
	[FieldOffset(Offset = "0x7C")]
	protected Vector4 mLerp23StartEnd;

	[Token(Token = "0x401AC0E")]
	[FieldOffset(Offset = "0x8C")]
	public Vector4 center;

	[Token(Token = "0x401AC0F")]
	[FieldOffset(Offset = "0x9C")]
	public Vector4 ellipse;

	[Token(Token = "0x401AC10")]
	[FieldOffset(Offset = "0xAC")]
	protected Vector4 mEllipse;

	[Token(Token = "0x6019D3F")]
	[Address(RVA = "0x1C62C98", Offset = "0x1C62C98", VA = "0x1C62C98")]
	public LobbyFog()
	{
	}

	[Token(Token = "0x6019D40")]
	[Address(RVA = "0x1C62F00", Offset = "0x1C62F00", VA = "0x1C62F00")]
	private void Start()
	{
	}

	[Token(Token = "0x6019D41")]
	[Address(RVA = "0x1C63254", Offset = "0x1C63254", VA = "0x1C63254")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019D42")]
	[Address(RVA = "0x1C63340", Offset = "0x1C63340", VA = "0x1C63340")]
	private void OnSceneChange(Scene scene1, Scene scene2)
	{
	}

	[Token(Token = "0x6019D43")]
	[Address(RVA = "0x1C63214", Offset = "0x1C63214", VA = "0x1C63214")]
	private void ResetUnityFog()
	{
	}

	[Token(Token = "0x6019D44")]
	[Address(RVA = "0x1C63344", Offset = "0x1C63344", VA = "0x1C63344")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6019D45")]
	[Address(RVA = "0x1C633F4", Offset = "0x1C633F4", VA = "0x1C633F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6019D46")]
	[Address(RVA = "0x1C634A4", Offset = "0x1C634A4", VA = "0x1C634A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6019D47")]
	[Address(RVA = "0x1C62FFC", Offset = "0x1C62FFC", VA = "0x1C62FFC")]
	protected void UpdateProps()
	{
	}
}
