using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2003E91")]
public class CameraReflection : MonoBehaviour
{
	[Token(Token = "0x2003E92")]
	public enum SizeEnum
	{
		[Token(Token = "0x401A6DD")]
		Sixteenth = 0x40,
		[Token(Token = "0x401A6DE")]
		Eighth = 0x80,
		[Token(Token = "0x401A6DF")]
		Quarter = 0x100,
		[Token(Token = "0x401A6E0")]
		Half = 0x200,
		[Token(Token = "0x401A6E1")]
		One = 0x400
	}

	[Token(Token = "0x2003E93")]
	public enum ReflectDistrict
	{
		[Token(Token = "0x401A6E3")]
		Sea,
		[Token(Token = "0x401A6E4")]
		Dam,
		[Token(Token = "0x401A6E5")]
		UnderDam
	}

	[Token(Token = "0x401A6CB")]
	public const int DISTRICT_COUNT = 3;

	[Token(Token = "0x401A6CC")]
	[FieldOffset(Offset = "0xC")]
	public CameraClearFlags clearFlag;

	[Token(Token = "0x401A6CD")]
	[FieldOffset(Offset = "0x10")]
	public Color backgroundColor;

	[Token(Token = "0x401A6CE")]
	[FieldOffset(Offset = "0x20")]
	public SizeEnum sizeType;

	[Token(Token = "0x401A6CF")]
	[FieldOffset(Offset = "0x24")]
	private float horizonY;

	[Token(Token = "0x401A6D0")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_reflectionCamera;

	[Token(Token = "0x401A6D1")]
	[FieldOffset(Offset = "0x2C")]
	private Camera m_ownerCamera;

	[Token(Token = "0x401A6D2")]
	[FieldOffset(Offset = "0x30")]
	private CommandBuffer[] m_CommandBuffers;

	[Token(Token = "0x401A6D3")]
	[FieldOffset(Offset = "0x34")]
	private HashSet<GameObject>[] m_needRenderObjs;

	[Token(Token = "0x401A6D4")]
	[FieldOffset(Offset = "0x38")]
	private HashSet<Material> m_receiversMats;

	[Token(Token = "0x401A6D5")]
	[FieldOffset(Offset = "0x3C")]
	private RenderTexture m_reflectionRT;

	[Token(Token = "0x401A6D6")]
	[FieldOffset(Offset = "0x40")]
	private int m_reflectionRTsize;

	[Token(Token = "0x401A6D7")]
	[FieldOffset(Offset = "0x44")]
	private Shader m_reflectionShader;

	[Token(Token = "0x401A6D8")]
	[FieldOffset(Offset = "0x48")]
	private List<Material>[] m_mats;

	[Token(Token = "0x401A6D9")]
	[FieldOffset(Offset = "0x4C")]
	private float m_horizonY;

	[Token(Token = "0x401A6DA")]
	[FieldOffset(Offset = "0x50")]
	private ReflectDistrict m_currentDis;

	[Token(Token = "0x401A6DB")]
	[FieldOffset(Offset = "0x54")]
	private bool m_fadeDone;

	[Token(Token = "0x17001BCF")]
	public bool Initialized
	{
		[Token(Token = "0x6019768")]
		[Address(RVA = "0x2309EB0", Offset = "0x2309EB0", VA = "0x2309EB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001BD0")]
	public float HorizonY
	{
		[Token(Token = "0x6019769")]
		[Address(RVA = "0x2309EC0", Offset = "0x2309EC0", VA = "0x2309EC0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601976A")]
		[Address(RVA = "0x2309EC8", Offset = "0x2309EC8", VA = "0x2309EC8")]
		private set
		{
		}
	}

	[Token(Token = "0x6019767")]
	[Address(RVA = "0x2309C34", Offset = "0x2309C34", VA = "0x2309C34")]
	public CameraReflection()
	{
	}

	[Token(Token = "0x601976B")]
	[Address(RVA = "0x230A0D8", Offset = "0x230A0D8", VA = "0x230A0D8")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x601976C")]
	[Address(RVA = "0x230A168", Offset = "0x230A168", VA = "0x230A168")]
	private void Initialize()
	{
	}

	[Token(Token = "0x601976D")]
	[Address(RVA = "0x230AA20", Offset = "0x230AA20", VA = "0x230AA20")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x601976E")]
	[Address(RVA = "0x230B084", Offset = "0x230B084", VA = "0x230B084")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601976F")]
	[Address(RVA = "0x230B0F8", Offset = "0x230B0F8", VA = "0x230B0F8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6019770")]
	[Address(RVA = "0x230B0FC", Offset = "0x230B0FC", VA = "0x230B0FC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6019771")]
	[Address(RVA = "0x230B318", Offset = "0x230B318", VA = "0x230B318")]
	private void UpdateRefCamera()
	{
	}

	[Token(Token = "0x6019772")]
	[Address(RVA = "0x230B0C0", Offset = "0x230B0C0", VA = "0x230B0C0")]
	private void BuildCommandBuffers()
	{
	}

	[Token(Token = "0x6019773")]
	[Address(RVA = "0x230B630", Offset = "0x230B630", VA = "0x230B630")]
	private void BuildCommandBuffer(int index)
	{
	}

	[Token(Token = "0x6019774")]
	[Address(RVA = "0x230B894", Offset = "0x230B894", VA = "0x230B894")]
	private void DrawObject(GameObject obj, int index)
	{
	}

	[Token(Token = "0x6019775")]
	[Address(RVA = "0x230C2A8", Offset = "0x230C2A8", VA = "0x230C2A8")]
	public void AddRenderObject(GameObject obj, int district)
	{
	}

	[Token(Token = "0x6019776")]
	[Address(RVA = "0x230C3C4", Offset = "0x230C3C4", VA = "0x230C3C4")]
	public void RemoveRenderObject(GameObject obj, int district)
	{
	}

	[Token(Token = "0x6019777")]
	[Address(RVA = "0x230C3C8", Offset = "0x230C3C8", VA = "0x230C3C8")]
	public void AddReceiver(GameObject obj)
	{
	}

	[Token(Token = "0x6019778")]
	[Address(RVA = "0x230C6B0", Offset = "0x230C6B0", VA = "0x230C6B0")]
	public void RemoveReceiver(GameObject obj)
	{
	}

	[Token(Token = "0x6019779")]
	[Address(RVA = "0x230AE7C", Offset = "0x230AE7C", VA = "0x230AE7C")]
	private void DestroyMaterials(int index)
	{
	}

	[Token(Token = "0x601977A")]
	[Address(RVA = "0x230C8F8", Offset = "0x230C8F8", VA = "0x230C8F8")]
	public void SetHorizon(ReflectDistrict dis, float y)
	{
	}

	[Token(Token = "0x601977B")]
	[Address(RVA = "0x230AA14", Offset = "0x230AA14", VA = "0x230AA14")]
	public void ResetHorizon()
	{
	}

	[Token(Token = "0x601977C")]
	[Address(RVA = "0x230C9E4", Offset = "0x230C9E4", VA = "0x230C9E4")]
	public void ReflectionFade(float previewHeight)
	{
	}
}
