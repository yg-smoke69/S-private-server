using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000228")]
public class SceneGraphicConfigItem
{
	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x8")]
	public bool EnableOcclusionCulling;

	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0xC")]
	public float CameraCollisionOffsetRight;

	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x10")]
	public float CameraCollisionOffsetBack;

	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x20DE05C", Offset = "0x20DE05C", VA = "0x20DE05C")]
	public SceneGraphicConfigItem()
	{
	}
}
