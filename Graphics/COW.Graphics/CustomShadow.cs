using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F37")]
public class CustomShadow : MonoBehaviour
{
	[Token(Token = "0x401AA45")]
	[FieldOffset(Offset = "0xC")]
	public Light m_light;

	[Token(Token = "0x401AA46")]
	[FieldOffset(Offset = "0x0")]
	public static Camera m_camera;

	[Token(Token = "0x401AA47")]
	[FieldOffset(Offset = "0x10")]
	private RenderTexture LCKPBLEJHMB;

	[Token(Token = "0x401AA48")]
	[FieldOffset(Offset = "0x14")]
	private Shader IFFKHCHPKPK;

	[Token(Token = "0x401AA49")]
	[FieldOffset(Offset = "0x18")]
	private Transform CKGOJBKMAHK;

	[Token(Token = "0x401AA4A")]
	[FieldOffset(Offset = "0x1C")]
	private Camera KANINONBOGA;

	[Token(Token = "0x401AA4B")]
	[FieldOffset(Offset = "0x20")]
	private bool NHMICNKPOJC;

	[Token(Token = "0x401AA4C")]
	[FieldOffset(Offset = "0x24")]
	public float m_CameraHeight;

	[Token(Token = "0x401AA4D")]
	[FieldOffset(Offset = "0x28")]
	private float NMNLPAKEOPN;

	[Token(Token = "0x401AA4E")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 FGGDDOEEJLN;

	[Token(Token = "0x401AA4F")]
	[FieldOffset(Offset = "0x38")]
	public float nearClipPlane;

	[Token(Token = "0x401AA50")]
	[FieldOffset(Offset = "0x3C")]
	public float farClipPlane;

	[Token(Token = "0x401AA51")]
	[FieldOffset(Offset = "0x40")]
	public int rtResolution;

	[Token(Token = "0x401AA52")]
	[FieldOffset(Offset = "0x44")]
	public float shadowStrength;

	[Token(Token = "0x401AA53")]
	private const string JCGFABNAJAI = "_CustomShadowMap";

	[Token(Token = "0x401AA54")]
	private const string JIJILMDDHFK = "_CustomShadowMatrix";

	[Token(Token = "0x401AA55")]
	[FieldOffset(Offset = "0x4")]
	private static CustomShadow _003CCCJNOOAKBOE_003Ek__BackingField;

	[Token(Token = "0x17001C25")]
	public bool IEFLCKOEEEL
	{
		[Token(Token = "0x6019BE0")]
		[Address(RVA = "0x25A5688", Offset = "0x25A5688", VA = "0x25A5688")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C26")]
	public static CustomShadow GAHBKGJAHPJ
	{
		[Token(Token = "0x6019BE1")]
		[Address(RVA = "0x25A5690", Offset = "0x25A5690", VA = "0x25A5690")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019BE2")]
		[Address(RVA = "0x25A571C", Offset = "0x25A571C", VA = "0x25A571C")]
		private set
		{
		}
	}

	[Token(Token = "0x6019BDF")]
	[Address(RVA = "0x25A55A8", Offset = "0x25A55A8", VA = "0x25A55A8")]
	public CustomShadow()
	{
	}

	[Token(Token = "0x6019BE3")]
	[Address(RVA = "0x25A57AC", Offset = "0x25A57AC", VA = "0x25A57AC")]
	public static void SetCastShadow(GameObject OMDFNKNJDII, bool MJJIFADPOGD)
	{
	}

	[Token(Token = "0x6019BE4")]
	[Address(RVA = "0x25A59EC", Offset = "0x25A59EC", VA = "0x25A59EC")]
	public static void SetCastShadowInChildren(GameObject OMDFNKNJDII, bool MJJIFADPOGD)
	{
	}

	[Token(Token = "0x6019BE5")]
	[Address(RVA = "0x25A5C64", Offset = "0x25A5C64", VA = "0x25A5C64")]
	public static void SetCastShadowInChildrenInAllMaterials(GameObject OMDFNKNJDII, bool MJJIFADPOGD)
	{
	}

	[Token(Token = "0x6019BE6")]
	[Address(RVA = "0x25A5EC0", Offset = "0x25A5EC0", VA = "0x25A5EC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019BE7")]
	[Address(RVA = "0x25A5F9C", Offset = "0x25A5F9C", VA = "0x25A5F9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6019BE8")]
	[Address(RVA = "0x25A64A8", Offset = "0x25A64A8", VA = "0x25A64A8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019BE9")]
	[Address(RVA = "0x25A674C", Offset = "0x25A674C", VA = "0x25A674C")]
	public static void ResetShadowMatrix()
	{
	}

	[Token(Token = "0x6019BEA")]
	[Address(RVA = "0x25A6864", Offset = "0x25A6864", VA = "0x25A6864")]
	public void SetFollowingCameraLight(Camera IFPMCEFKDEC, Light CHFBCLDFCOJ)
	{
	}

	[Token(Token = "0x6019BEB")]
	[Address(RVA = "0x25A7120", Offset = "0x25A7120", VA = "0x25A7120")]
	public void ForceEnableShadow(bool HGBDLAAICFB)
	{
	}

	[Token(Token = "0x6019BEC")]
	[Address(RVA = "0x25A7158", Offset = "0x25A7158", VA = "0x25A7158")]
	public void SetFollowingCam(Camera KFGFLKFGPBA)
	{
	}

	[Token(Token = "0x6019BED")]
	[Address(RVA = "0x25A6044", Offset = "0x25A6044", VA = "0x25A6044")]
	private void IJCFKFONDFC()
	{
	}

	[Token(Token = "0x6019BEE")]
	[Address(RVA = "0x25A74CC", Offset = "0x25A74CC", VA = "0x25A74CC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6019BEF")]
	[Address(RVA = "0x25A7160", Offset = "0x25A7160", VA = "0x25A7160")]
	private void FEDDFAFBGNM()
	{
	}

	[Token(Token = "0x6019BF0")]
	[Address(RVA = "0x25A6574", Offset = "0x25A6574", VA = "0x25A6574")]
	private void CKNCPMDPGMC()
	{
	}

	[Token(Token = "0x6019BF1")]
	[Address(RVA = "0x25A74D0", Offset = "0x25A74D0", VA = "0x25A74D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6019BF2")]
	[Address(RVA = "0x25A698C", Offset = "0x25A698C", VA = "0x25A698C")]
	private void NJEKFNNKLGJ()
	{
	}
}
