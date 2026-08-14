using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004188")]
public class Debug_ColliderTrigger : MonoBehaviour
{
	[Token(Token = "0x401B78D")]
	[FieldOffset(Offset = "0xC")]
	public Mesh BoxMesh;

	[Token(Token = "0x401B78E")]
	[FieldOffset(Offset = "0x10")]
	public Mesh SphereMesh;

	[Token(Token = "0x401B78F")]
	[FieldOffset(Offset = "0x14")]
	public Mesh CapsuleMesh;

	[Token(Token = "0x401B790")]
	[FieldOffset(Offset = "0x18")]
	public Shader DebugColliderShader;

	[Token(Token = "0x401B791")]
	[FieldOffset(Offset = "0x1C")]
	public bool activateDebugCollider;

	[Token(Token = "0x401B792")]
	[FieldOffset(Offset = "0x20")]
	private Material _DebugColliderMat;

	[Token(Token = "0x401B793")]
	[FieldOffset(Offset = "0x24")]
	private Material _DebugTriggerMat;

	[Token(Token = "0x401B794")]
	[FieldOffset(Offset = "0x28")]
	private bool ShowColliderFlag;

	[Token(Token = "0x401B795")]
	[FieldOffset(Offset = "0x29")]
	private bool ShowTriggerFlag;

	[Token(Token = "0x401B796")]
	[FieldOffset(Offset = "0x2C")]
	private GameObject _tmpCollider_TriggerObj;

	[Token(Token = "0x401B797")]
	[FieldOffset(Offset = "0x30")]
	private GameObject _tmpColliderObj;

	[Token(Token = "0x401B798")]
	[FieldOffset(Offset = "0x34")]
	private GameObject _tmpTriggerObj;

	[Token(Token = "0x401B799")]
	[FieldOffset(Offset = "0x38")]
	private bool m_showCollider;

	[Token(Token = "0x401B79A")]
	[FieldOffset(Offset = "0x39")]
	private bool m_showTrigger;

	[Token(Token = "0x401B79B")]
	[FieldOffset(Offset = "0x3C")]
	private GameObject _tmpBoxColliderObj;

	[Token(Token = "0x401B79C")]
	[FieldOffset(Offset = "0x40")]
	private GameObject _tmpBoxTriggerObj;

	[Token(Token = "0x401B79D")]
	[FieldOffset(Offset = "0x44")]
	private GameObject _tmpSphereColliderObj;

	[Token(Token = "0x401B79E")]
	[FieldOffset(Offset = "0x48")]
	private GameObject _tmpSphereTriggerObj;

	[Token(Token = "0x401B79F")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject _tmpCapsuleColliderObj;

	[Token(Token = "0x401B7A0")]
	[FieldOffset(Offset = "0x50")]
	private GameObject _tmpCapsuleTriggerObj;

	[Token(Token = "0x401B7A1")]
	[FieldOffset(Offset = "0x54")]
	private GameObject _tmpMeshColliderObj;

	[Token(Token = "0x401B7A2")]
	[FieldOffset(Offset = "0x58")]
	private GameObject _tmpMeshTriggerObj;

	[Token(Token = "0x401B7A3")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<string, List<GameObject>> debugMeshRendererDic;

	[Token(Token = "0x601AC4A")]
	[Address(RVA = "0x23114D4", Offset = "0x23114D4", VA = "0x23114D4")]
	public Debug_ColliderTrigger()
	{
	}

	[Token(Token = "0x601AC4B")]
	[Address(RVA = "0x23114DC", Offset = "0x23114DC", VA = "0x23114DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AC4C")]
	[Address(RVA = "0x231188C", Offset = "0x231188C", VA = "0x231188C")]
	public void Init()
	{
	}

	[Token(Token = "0x601AC4D")]
	[Address(RVA = "0x2311AA4", Offset = "0x2311AA4", VA = "0x2311AA4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601AC4E")]
	[Address(RVA = "0x2311E34", Offset = "0x2311E34", VA = "0x2311E34")]
	public void UnloadGameObject(string sceneName)
	{
	}

	[Token(Token = "0x601AC4F")]
	[Address(RVA = "0x2312018", Offset = "0x2312018", VA = "0x2312018")]
	private void AddMeshColShow()
	{
	}

	[Token(Token = "0x601AC50")]
	[Address(RVA = "0x2312450", Offset = "0x2312450", VA = "0x2312450")]
	private void OnShowCollider(object[] data)
	{
	}

	[Token(Token = "0x601AC51")]
	[Address(RVA = "0x2312698", Offset = "0x2312698", VA = "0x2312698")]
	private void OnShowTrigger(object[] data)
	{
	}

	[Token(Token = "0x601AC52")]
	[Address(RVA = "0x2312774", Offset = "0x2312774", VA = "0x2312774")]
	private void OnRebuildCollider(object[] data)
	{
	}

	[Token(Token = "0x601AC53")]
	[Address(RVA = "0x23127AC", Offset = "0x23127AC", VA = "0x23127AC")]
	private void OnDestroyCollider(object[] data)
	{
	}

	[Token(Token = "0x601AC54")]
	[Address(RVA = "0x2311CCC", Offset = "0x2311CCC", VA = "0x2311CCC")]
	private void DestroyAllAssets()
	{
	}

	[Token(Token = "0x601AC55")]
	[Address(RVA = "0x231157C", Offset = "0x231157C", VA = "0x231157C")]
	private void InitColliderMats()
	{
	}

	[Token(Token = "0x601AC56")]
	[Address(RVA = "0x2311760", Offset = "0x2311760", VA = "0x2311760")]
	private void InitAllMesh()
	{
	}

	[Token(Token = "0x601AC57")]
	[Address(RVA = "0x2312890", Offset = "0x2312890", VA = "0x2312890")]
	private void CreateColliderMesh()
	{
	}

	[Token(Token = "0x601AC58")]
	[Address(RVA = "0x2312584", Offset = "0x2312584", VA = "0x2312584")]
	public void PaintCollider(BoxCollider[] boxColliders, SphereCollider[] sphereColliders, CapsuleCollider[] capsuleColliders, MeshCollider[] meshColliders, [Optional] string sceneName)
	{
	}

	[Token(Token = "0x601AC59")]
	[Address(RVA = "0x2315FD8", Offset = "0x2315FD8", VA = "0x2315FD8")]
	private bool CheckRequireName(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601AC5A")]
	[Address(RVA = "0x2316128", Offset = "0x2316128", VA = "0x2316128")]
	private Transform FindStreamAnchor(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x601AC5B")]
	[Address(RVA = "0x231620C", Offset = "0x231620C", VA = "0x231620C")]
	private string GetRootNode(Transform colliderTrans)
	{
		return null;
	}

	[Token(Token = "0x601AC5C")]
	[Address(RVA = "0x2312FD8", Offset = "0x2312FD8", VA = "0x2312FD8")]
	private void CreateBoxMesh(GameObject _tmpColliderObj, GameObject _tmpTriggerObj)
	{
	}

	[Token(Token = "0x601AC5D")]
	[Address(RVA = "0x2316360", Offset = "0x2316360", VA = "0x2316360")]
	private void ProcessClimbingTrigger(ClimbingTrigger climbingTrigger)
	{
	}

	[Token(Token = "0x601AC5E")]
	[Address(RVA = "0x2313FC8", Offset = "0x2313FC8", VA = "0x2313FC8")]
	private void PaintBoxCollider(BoxCollider[] boxColliders, [Optional] string sceneName)
	{
	}

	[Token(Token = "0x601AC5F")]
	[Address(RVA = "0x23133D4", Offset = "0x23133D4", VA = "0x23133D4")]
	private void CreateSphereMesh(GameObject _tmpColliderObj, GameObject _tmpTriggerObj)
	{
	}

	[Token(Token = "0x601AC60")]
	[Address(RVA = "0x2314844", Offset = "0x2314844", VA = "0x2314844")]
	public void PaintSphereCollider(SphereCollider[] sphereColliders, [Optional] string sceneName)
	{
	}

	[Token(Token = "0x601AC61")]
	[Address(RVA = "0x23137D0", Offset = "0x23137D0", VA = "0x23137D0")]
	private void CreateCapsuleMesh(GameObject _tmpColliderObj, GameObject _tmpTriggerObj)
	{
	}

	[Token(Token = "0x601AC62")]
	[Address(RVA = "0x2315074", Offset = "0x2315074", VA = "0x2315074")]
	public void PaintCapsuleCollider(CapsuleCollider[] capsuleColliders, [Optional] string sceneName)
	{
	}

	[Token(Token = "0x601AC63")]
	[Address(RVA = "0x2313BCC", Offset = "0x2313BCC", VA = "0x2313BCC")]
	private void CreateMeshMesh(GameObject _tmpColliderObj, GameObject _tmpTriggerObj)
	{
	}

	[Token(Token = "0x601AC64")]
	[Address(RVA = "0x23158B0", Offset = "0x23158B0", VA = "0x23158B0")]
	public void PaintMeshCollider(MeshCollider[] meshColliders, [Optional] string sceneName)
	{
	}

	[Token(Token = "0x601AC65")]
	[Address(RVA = "0x2312790", Offset = "0x2312790", VA = "0x2312790")]
	public void RebuildAllMesh()
	{
	}

	[Token(Token = "0x601AC66")]
	[Address(RVA = "0x23127B0", Offset = "0x23127B0", VA = "0x23127B0")]
	public void DestroyAllMesh()
	{
	}

	[Token(Token = "0x601AC67")]
	[Address(RVA = "0x23125D8", Offset = "0x23125D8", VA = "0x23125D8")]
	public void ShowColliders(bool isShow = true)
	{
	}

	[Token(Token = "0x601AC68")]
	[Address(RVA = "0x23126B4", Offset = "0x23126B4", VA = "0x23126B4")]
	public void ShowTriggers(bool isShow = true)
	{
	}
}
