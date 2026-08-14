using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A48")]
public class PreviewWeaponTransform : MonoBehaviour
{
	[Token(Token = "0x2000A49")]
	public enum WeaponPreviewType
	{
		[Token(Token = "0x4005B93")]
		None,
		[Token(Token = "0x4005B94")]
		Blade,
		[Token(Token = "0x4005B95")]
		Scabbard
	}

	[Token(Token = "0x4005B8E")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 localPos;

	[Token(Token = "0x4005B8F")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 localScale;

	[Token(Token = "0x4005B90")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 localQuaternion;

	[Token(Token = "0x4005B91")]
	[FieldOffset(Offset = "0x30")]
	public WeaponPreviewType previewType;

	[Token(Token = "0x6004FEF")]
	[Address(RVA = "0x19682B4", Offset = "0x19682B4", VA = "0x19682B4")]
	public PreviewWeaponTransform()
	{
	}
}
