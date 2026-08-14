using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A64")]
public class AvatarExtraAmbient : MonoBehaviour
{
	[Token(Token = "0x2000A65")]
	public enum Part
	{
		[Token(Token = "0x4005C1E")]
		Cloth,
		[Token(Token = "0x4005C1F")]
		Skin
	}

	[Token(Token = "0x4005C1B")]
	[FieldOffset(Offset = "0xC")]
	public Part part;

	[Token(Token = "0x4005C1C")]
	[FieldOffset(Offset = "0x10")]
	public float ambient;

	[Token(Token = "0x6005080")]
	[Address(RVA = "0x2ECF60C", Offset = "0x2ECF60C", VA = "0x2ECF60C")]
	public AvatarExtraAmbient()
	{
	}

	[Token(Token = "0x6005081")]
	[Address(RVA = "0x2ECF614", Offset = "0x2ECF614", VA = "0x2ECF614")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005082")]
	[Address(RVA = "0x2ECF6A4", Offset = "0x2ECF6A4", VA = "0x2ECF6A4")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6005083")]
	[Address(RVA = "0x2ECF618", Offset = "0x2ECF618", VA = "0x2ECF618")]
	private void ApplyAmbient()
	{
	}
}
