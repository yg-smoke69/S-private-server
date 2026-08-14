using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200418E")]
public class TestCloth : MonoBehaviour
{
	[Token(Token = "0x200418F")]
	public enum Gender
	{
		[Token(Token = "0x401B7B3")]
		Female,
		[Token(Token = "0x401B7B4")]
		Male
	}

	[Token(Token = "0x401B7B0")]
	[FieldOffset(Offset = "0xC")]
	private readonly string[] DONT_DESTROY_RESOURCES;

	[Token(Token = "0x401B7B1")]
	[FieldOffset(Offset = "0x10")]
	public Gender gender;

	[Token(Token = "0x601AC73")]
	[Address(RVA = "0x21E02F0", Offset = "0x21E02F0", VA = "0x21E02F0")]
	public TestCloth()
	{
	}

	[Token(Token = "0x601AC74")]
	[Address(RVA = "0x21E03E4", Offset = "0x21E03E4", VA = "0x21E03E4")]
	private void Start()
	{
	}

	[Token(Token = "0x601AC75")]
	[Address(RVA = "0x21E0994", Offset = "0x21E0994", VA = "0x21E0994")]
	private void Update()
	{
	}
}
