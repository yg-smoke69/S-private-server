using AmplifyColor;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003AF4")]
public class AmplifyColorVolumeBase : MonoBehaviour
{
	[Token(Token = "0x40191A4")]
	[FieldOffset(Offset = "0xC")]
	public Texture2D LutTexture;

	[Token(Token = "0x40191A5")]
	[FieldOffset(Offset = "0x10")]
	public float Exposure;

	[Token(Token = "0x40191A6")]
	[FieldOffset(Offset = "0x14")]
	public float EnterBlendTime;

	[Token(Token = "0x40191A7")]
	[FieldOffset(Offset = "0x18")]
	public int Priority;

	[Token(Token = "0x40191A8")]
	[FieldOffset(Offset = "0x1C")]
	public bool ShowInSceneView;

	[Token(Token = "0x40191A9")]
	[FieldOffset(Offset = "0x20")]
	public VolumeEffectContainer EffectContainer;

	[Token(Token = "0x6017653")]
	[Address(RVA = "0x2ECA120", Offset = "0x2ECA120", VA = "0x2ECA120")]
	public AmplifyColorVolumeBase()
	{
	}
}
