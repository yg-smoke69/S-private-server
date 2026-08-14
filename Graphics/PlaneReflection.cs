using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2000005")]
public class PlaneReflection : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	public enum Dimension
	{
		[Token(Token = "0x4000032")]
		x128 = 0x80,
		[Token(Token = "0x4000033")]
		x256 = 0x100,
		[Token(Token = "0x4000034")]
		x512 = 0x200,
		[Token(Token = "0x4000035")]
		x1024 = 0x400,
		[Token(Token = "0x4000036")]
		x2048 = 0x800,
		[Token(Token = "0x4000037")]
		x4096 = 0x1000
	}

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0xC")]
	public Shader convolveShader;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x10")]
	public Dimension reflectionMapSize;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x14")]
	public LayerMask reflectLayerMask;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x18")]
	public float clipPlaneOffset;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x1C")]
	public bool clipSkyDome;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x20")]
	public float nearPlaneDistance;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x24")]
	public float farPlaneDistance;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x28")]
	public float mipShift;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x2C")]
	public bool useDepth;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x30")]
	public float depthScale;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x34")]
	public float depthExponent;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x38")]
	public float depthRayPinchFadeSteps;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x3C")]
	public bool renderShadows;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x40")]
	public float shadowDistance;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x44")]
	public int maxPixelLights;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x48")]
	public Color clearColor;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x58")]
	public RenderingPath renderingPath;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x5C")]
	private RenderTexture m_reflectionMap;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x60")]
	private RenderTexture m_reflectionDepthMap;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x64")]
	private CommandBuffer m_copyDepthCB;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x68")]
	private Camera m_reflectionCamera;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x6C")]
	private Camera m_renderCamera;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x70")]
	private Material[] m_materials;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x74")]
	private Material m_convolveMaterial;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x78")]
	public bool ssnap;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 spos;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 sup;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x94")]
	private Quaternion srot;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0xA4")]
	private float sfov;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0xA8")]
	private float snear;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0xAC")]
	private float sfar;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0xB0")]
	private float saspect;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1E19BD0", Offset = "0x1E19BD0", VA = "0x1E19BD0")]
	public PlaneReflection()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1E19CE8", Offset = "0x1E19CE8", VA = "0x1E19CE8")]
	private bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1E19D9C", Offset = "0x1E19D9C", VA = "0x1E19D9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1E1A85C", Offset = "0x1E1A85C", VA = "0x1E1A85C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1E1AA58", Offset = "0x1E1AA58", VA = "0x1E1AA58")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1E1AB38", Offset = "0x1E1AB38", VA = "0x1E1AB38")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1E1ACA4", Offset = "0x1E1ACA4", VA = "0x1E1ACA4")]
	public void OnWillRenderObject()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1E1A330", Offset = "0x1E1A330", VA = "0x1E1A330")]
	private void EnsureReflectionTexture()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1E1A668", Offset = "0x1E1A668", VA = "0x1E1A668")]
	private void EnsureResolveDepthHooks()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1E1C190", Offset = "0x1E1C190", VA = "0x1E1C190")]
	private void SetupConvolveParams(Vector3 camPos, Vector3 camRgt, Vector3 camUp, Vector3 camFwd, Matrix4x4 reflectionMatrix, Vector3 planeNormal)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1E1CC04", Offset = "0x1E1CC04", VA = "0x1E1CC04")]
	private void Convolve(RenderTexture reflectionMap0, RenderTexture reflectionDepth)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1E1CD0C", Offset = "0x1E1CD0C", VA = "0x1E1CD0C")]
	private void ConvolveStep(int step, RenderTexture srcMap, int srcMip, int dstMip)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1E1CFBC", Offset = "0x1E1CFBC", VA = "0x1E1CFBC")]
	private static void CustomGraphicsBlit(RenderTexture src, Material mat, int pass)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1E1D15C", Offset = "0x1E1D15C", VA = "0x1E1D15C")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1E19EE4", Offset = "0x1E19EE4", VA = "0x1E19EE4")]
	private Camera EnsureReflectionCamera(Camera renderCamera)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1E1C098", Offset = "0x1E1C098", VA = "0x1E1C098")]
	private static Vector3 ReflectVector(Vector3 vec, Vector3 normal)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1E1BDC4", Offset = "0x1E1BDC4", VA = "0x1E1BDC4")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1E1D210", Offset = "0x1E1D210", VA = "0x1E1D210")]
	private void OnDrawGizmos()
	{
	}
}
