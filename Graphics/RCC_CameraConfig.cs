using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BBB")]
public class RCC_CameraConfig : MonoBehaviour
{
	[Token(Token = "0x40196C2")]
	[FieldOffset(Offset = "0xC")]
	public bool automatic;

	[Token(Token = "0x40196C3")]
	[FieldOffset(Offset = "0x10")]
	private Bounds combinedBounds;

	[Token(Token = "0x40196C4")]
	[FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x40196C5")]
	[FieldOffset(Offset = "0x2C")]
	public float height;

	[Token(Token = "0x6017D2E")]
	[Address(RVA = "0x1E33F04", Offset = "0x1E33F04", VA = "0x1E33F04")]
	public RCC_CameraConfig()
	{
	}

	[Token(Token = "0x6017D2F")]
	[Address(RVA = "0x1E33F2C", Offset = "0x1E33F2C", VA = "0x1E33F2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6017D30")]
	[Address(RVA = "0x1E3228C", Offset = "0x1E3228C", VA = "0x1E3228C")]
	public void SetCameraSettings()
	{
	}

	[Token(Token = "0x6017D31")]
	[Address(RVA = "0x1E340BC", Offset = "0x1E340BC", VA = "0x1E340BC")]
	public static float MaxBoundsExtent(Transform obj)
	{
		return default(float);
	}
}
