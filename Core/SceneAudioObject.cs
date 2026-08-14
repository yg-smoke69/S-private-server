using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000400")]
public class SceneAudioObject : MonoBehaviour
{
	[Token(Token = "0x2000401")]
	public enum EMultiPositionType
	{
		[Token(Token = "0x4003A4A")]
		Simple_Mode,
		[Token(Token = "0x4003A4B")]
		Large_Mode,
		[Token(Token = "0x4003A4C")]
		MultiPosition_Mode
	}

	[Token(Token = "0x2000402")]
	public enum EAttenuationSphere
	{
		[Token(Token = "0x4003A4E")]
		Dont_Show,
		[Token(Token = "0x4003A4F")]
		Current_Event_Only,
		[Token(Token = "0x4003A50")]
		All_Events
	}

	[Token(Token = "0x4003A46")]
	[FieldOffset(Offset = "0xC")]
	private string m_ResourceID;

	[Token(Token = "0x4003A47")]
	[FieldOffset(Offset = "0x10")]
	private EMultiPositionType m_PositionType;

	[Token(Token = "0x4003A48")]
	[FieldOffset(Offset = "0x14")]
	private EAttenuationSphere m_ShowAttenuationSphere;

	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x21C0A38", Offset = "0x21C0A38", VA = "0x21C0A38")]
	public SceneAudioObject()
	{
	}

	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x21C0A50", Offset = "0x21C0A50", VA = "0x21C0A50")]
	private void Awake()
	{
	}
}
