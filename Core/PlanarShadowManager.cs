using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2003FA0")]
public class PlanarShadowManager : MonoSingleton<PlanarShadowManager>
{
	[Token(Token = "0x401ACDE")]
	private const CameraEvent CAMERA_EVENT = 11;

	[Token(Token = "0x401ACDF")]
	[FieldOffset(Offset = "0xC")]
	private Material mainShadowMat;

	[Token(Token = "0x401ACE0")]
	[FieldOffset(Offset = "0x10")]
	private int centerPoint;

	[Token(Token = "0x401ACE1")]
	[FieldOffset(Offset = "0x14")]
	private int planeNormal;

	[Token(Token = "0x401ACE2")]
	[FieldOffset(Offset = "0x18")]
	private int mainLightDir;

	[Token(Token = "0x401ACE3")]
	[FieldOffset(Offset = "0x1C")]
	private HashSet<RenderNode_Shadow> m_rendererList;

	[Token(Token = "0x401ACE4")]
	[FieldOffset(Offset = "0x20")]
	private HashSet<LightNode_Shadow> m_lightList;

	[Token(Token = "0x401ACE5")]
	[FieldOffset(Offset = "0x24")]
	private LightNode_Shadow m_mainLight;

	[Token(Token = "0x401ACE6")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_camera;

	[Token(Token = "0x401ACE7")]
	[FieldOffset(Offset = "0x2C")]
	private Transform m_shadowPlane;

	[Token(Token = "0x401ACE8")]
	[FieldOffset(Offset = "0x30")]
	private Renderer m_shadowPlaneRenderer;

	[Token(Token = "0x401ACE9")]
	[FieldOffset(Offset = "0x34")]
	private ShadowResolution originalShadowResolution;

	[Token(Token = "0x6019E2E")]
	[Address(RVA = "0x1C7BCA0", Offset = "0x1C7BCA0", VA = "0x1C7BCA0")]
	public PlanarShadowManager()
	{
	}

	[Token(Token = "0x6019E2F")]
	[Address(RVA = "0x1C7BDA0", Offset = "0x1C7BDA0", VA = "0x1C7BDA0", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6019E30")]
	[Address(RVA = "0x1C7BEF0", Offset = "0x1C7BEF0", VA = "0x1C7BEF0")]
	public void UpdatePlanarShadow(Renderer[] renderers, Camera camera, GameObject avatarLightGo, Transform shadowPlane)
	{
	}

	[Token(Token = "0x6019E31")]
	[Address(RVA = "0x1C7C570", Offset = "0x1C7C570", VA = "0x1C7C570")]
	public void UpdatePlanarShadow(Renderer renderer, Camera camera, GameObject avatarLightGo, Transform shadowPlane)
	{
	}

	[Token(Token = "0x6019E32")]
	[Address(RVA = "0x1C7C268", Offset = "0x1C7C268", VA = "0x1C7C268")]
	public void UpdateRenderer(Renderer[] renderers)
	{
	}

	[Token(Token = "0x6019E33")]
	[Address(RVA = "0x1C7C5B8", Offset = "0x1C7C5B8", VA = "0x1C7C5B8")]
	public void UpdateRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x6019E34")]
	[Address(RVA = "0x1C7C2CC", Offset = "0x1C7C2CC", VA = "0x1C7C2CC")]
	public void UpdateAvatarLight(GameObject avatarLightGo)
	{
	}

	[Token(Token = "0x6019E35")]
	[Address(RVA = "0x1C7BF38", Offset = "0x1C7BF38", VA = "0x1C7BF38")]
	public void UpdateReceivedShadowPlane(Transform lobbyShadowParent)
	{
	}

	[Token(Token = "0x6019E36")]
	[Address(RVA = "0x1C7C1D4", Offset = "0x1C7C1D4", VA = "0x1C7C1D4")]
	public void UpdateCamera(Camera camera)
	{
	}

	[Token(Token = "0x6019E37")]
	[Address(RVA = "0x1C7CDA0", Offset = "0x1C7CDA0", VA = "0x1C7CDA0")]
	private void FindMainLight(LightNode_Shadow lightNode, bool isActive)
	{
	}

	[Token(Token = "0x6019E38")]
	[Address(RVA = "0x1C7D450", Offset = "0x1C7D450", VA = "0x1C7D450")]
	private void UpdateMainLight()
	{
	}

	[Token(Token = "0x6019E39")]
	[Address(RVA = "0x1C7D708", Offset = "0x1C7D708", VA = "0x1C7D708")]
	private bool CheckShadowCondition(RenderNode_Shadow node)
	{
		return default(bool);
	}

	[Token(Token = "0x6019E3A")]
	[Address(RVA = "0x1C7CBDC", Offset = "0x1C7CBDC", VA = "0x1C7CBDC")]
	private void InitCommandBuffer(Renderer renderer, CommandBuffer commandBuffer)
	{
	}

	[Token(Token = "0x6019E3B")]
	[Address(RVA = "0x1C7D27C", Offset = "0x1C7D27C", VA = "0x1C7D27C")]
	private void RefreshCommandBuffer()
	{
	}

	[Token(Token = "0x6019E3C")]
	[Address(RVA = "0x1C7DD60", Offset = "0x1C7DD60", VA = "0x1C7DD60")]
	private void RefreshCommandBuffer(RenderNode_Shadow node, bool isActive)
	{
	}

	[Token(Token = "0x6019E3D")]
	[Address(RVA = "0x1C7DBB8", Offset = "0x1C7DBB8", VA = "0x1C7DBB8")]
	private void MainCameraController(int mode, [Optional] CommandBuffer commandBuffer)
	{
	}

	[Token(Token = "0x6019E3E")]
	[Address(RVA = "0x1C7DF04", Offset = "0x1C7DF04", VA = "0x1C7DF04")]
	public void OnRendererStateChanged(RenderNode_Shadow rnode, bool isActive)
	{
	}

	[Token(Token = "0x6019E3F")]
	[Address(RVA = "0x1C7E018", Offset = "0x1C7E018", VA = "0x1C7E018")]
	public void OnLightStateChanged(LightNode_Shadow lnode, bool isActive)
	{
	}

	[Token(Token = "0x6019E40")]
	[Address(RVA = "0x1C7E128", Offset = "0x1C7E128", VA = "0x1C7E128")]
	public void OnPlaneStateChanged(PlaneNode_Shadow pnode)
	{
	}

	[Token(Token = "0x6019E41")]
	[Address(RVA = "0x1C7BDC4", Offset = "0x1C7BDC4", VA = "0x1C7BDC4")]
	private void InitMainShadowMaterial()
	{
	}

	[Token(Token = "0x6019E42")]
	[Address(RVA = "0x1C7E2A4", Offset = "0x1C7E2A4", VA = "0x1C7E2A4", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6019E43")]
	[Address(RVA = "0x1C7DDD4", Offset = "0x1C7DDD4", VA = "0x1C7DDD4")]
	private void SwithShadowState(bool drawingPlanarShadow)
	{
	}

	[Token(Token = "0x6019E44")]
	[Address(RVA = "0x1C7CB48", Offset = "0x1C7CB48", VA = "0x1C7CB48")]
	private bool IsSkinnedMeshRenderer(Renderer renderer)
	{
		return default(bool);
	}
}
