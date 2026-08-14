using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW;

[Token(Token = "0x200040A")]
internal class IngameAvatarClothEffectComponent : MonoBehaviour
{
	[Token(Token = "0x200040B")]
	public class EffectDataBase
	{
		[Token(Token = "0x4003AD6")]
		[FieldOffset(Offset = "0x8")]
		public ResourceID ResId;

		[Token(Token = "0x4003AD7")]
		[FieldOffset(Offset = "0xC")]
		public bool IsLoaded;

		[Token(Token = "0x4003AD8")]
		[FieldOffset(Offset = "0x10")]
		public uint LoadingTicket;

		[Token(Token = "0x4003AD9")]
		[FieldOffset(Offset = "0x14")]
		public List<GameObject> GameObjects;

		[Token(Token = "0x170001BB")]
		public bool IsLoading
		{
			[Token(Token = "0x60013DB")]
			[Address(RVA = "0x2C7A16C", Offset = "0x2C7A16C", VA = "0x2C7A16C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x2C7DC18", Offset = "0x2C7DC18", VA = "0x2C7DC18")]
		public EffectDataBase()
		{
		}

		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x2C7DC88", Offset = "0x2C7DC88", VA = "0x2C7DC88", Slot = "4")]
		public virtual void Reset()
		{
		}
	}

	[Token(Token = "0x200040C")]
	public class ClothEffectObject : EffectDataBase
	{
		[Token(Token = "0x4003ADA")]
		[FieldOffset(Offset = "0x18")]
		public UIModelAvatarBase.EWardrobeType Type;

		[Token(Token = "0x4003ADB")]
		[FieldOffset(Offset = "0x1C")]
		public BitArrayBoolean IsVisible;

		[Token(Token = "0x4003ADC")]
		[FieldOffset(Offset = "0x20")]
		public GameObject EffectGo;

		[Token(Token = "0x4003ADD")]
		[FieldOffset(Offset = "0x24")]
		public bool extraEffect;

		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x2C7A4D0", Offset = "0x2C7A4D0", VA = "0x2C7A4D0")]
		public ClothEffectObject(UIModelAvatarBase.EWardrobeType type)
		{
		}

		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x2C7DC20", Offset = "0x2C7DC20", VA = "0x2C7DC20", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x2C7DD48", Offset = "0x2C7DD48", VA = "0x2C7DD48")]
		public void _003C_003EiFixBaseProxy_Reset()
		{
		}
	}

	[Token(Token = "0x200040D")]
	private class DynamicEffectData : EffectDataBase
	{
		[Token(Token = "0x4003ADE")]
		[FieldOffset(Offset = "0x18")]
		public int Id;

		[Token(Token = "0x4003ADF")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsVisible;

		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x2C7B794", Offset = "0x2C7B794", VA = "0x2C7B794")]
		public DynamicEffectData()
		{
		}
	}

	[Token(Token = "0x4003ACA")]
	[FieldOffset(Offset = "0xC")]
	private IUmaAvatar m_Avatar;

	[Token(Token = "0x4003ACB")]
	[FieldOffset(Offset = "0x10")]
	public bool AsyncLoading;

	[Token(Token = "0x4003ACC")]
	[FieldOffset(Offset = "0x11")]
	private bool PoolDynamicEffects;

	[Token(Token = "0x4003ACD")]
	private const bool AllowsAnimationInDynamicEffects = false;

	[Token(Token = "0x4003ACE")]
	[FieldOffset(Offset = "0x12")]
	public bool CastShadow;

	[Token(Token = "0x4003ACF")]
	[FieldOffset(Offset = "0x14")]
	private GameObject m_TempBackpack;

	[Token(Token = "0x4003AD0")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, ClothEffectObject> m_ClothEffects;

	[Token(Token = "0x4003AD1")]
	[FieldOffset(Offset = "0x1C")]
	private List<DynamicEffectData> m_DynamicEffects;

	[Token(Token = "0x4003AD2")]
	[FieldOffset(Offset = "0x0")]
	private static List<DynamicEffectData> s_DynamicEffectsPool;

	[Token(Token = "0x4003AD3")]
	[FieldOffset(Offset = "0x4")]
	private static List<ParticleSystem> s_SharedTmpParticlesList;

	[Token(Token = "0x4003AD4")]
	[FieldOffset(Offset = "0x8")]
	private static List<Renderer> s_SharedTmpRenderList;

	[Token(Token = "0x4003AD5")]
	[FieldOffset(Offset = "0xC")]
	private static List<Animator> s_SharedTmpAnimatorList;

	[Token(Token = "0x60013B1")]
	[Address(RVA = "0x2C7836C", Offset = "0x2C7836C", VA = "0x2C7836C")]
	public IngameAvatarClothEffectComponent()
	{
	}

	[Token(Token = "0x60013B2")]
	[Address(RVA = "0x2C7837C", Offset = "0x2C7837C", VA = "0x2C7837C")]
	private void Start()
	{
	}

	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x2C78494", Offset = "0x2C78494", VA = "0x2C78494")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x2C7889C", Offset = "0x2C7889C", VA = "0x2C7889C")]
	private void PlayIngameAnimEffect(GameObject prefab, UIModelAvatarBase.EWardrobeType wType, bool isPrefab = true, [Optional] List<GameObject> gos)
	{
	}

	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x2C78EC0", Offset = "0x2C78EC0", VA = "0x2C78EC0")]
	private void ProcessBoneNameRefsIngame(GameObject go, UIModelAvatarBase.EWardrobeType wType, [Optional] List<GameObject> gos)
	{
	}

	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x2C79778", Offset = "0x2C79778", VA = "0x2C79778")]
	public void SetShowBackpack(GameObject obj)
	{
	}

	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x2C795D8", Offset = "0x2C795D8", VA = "0x2C795D8")]
	private static bool ScaleInLocalSpace(GameObject o)
	{
		return default(bool);
	}

	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x2C797D8", Offset = "0x2C797D8", VA = "0x2C797D8")]
	public void ChangeMeshLayer(int layer)
	{
	}

	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x2C79CA8", Offset = "0x2C79CA8", VA = "0x2C79CA8")]
	private void CancelEffectLoading(EffectDataBase data, bool pool)
	{
	}

	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x2C79A7C", Offset = "0x2C79A7C", VA = "0x2C79A7C")]
	private void ChangeMeshLayer(EffectDataBase data, int layer)
	{
	}

	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x2C79E50", Offset = "0x2C79E50", VA = "0x2C79E50")]
	public Dictionary<int, ClothEffectObject> GetClothEffects()
	{
		return null;
	}

	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x2C79EA8", Offset = "0x2C79EA8", VA = "0x2C79EA8")]
	public ClothEffectObject GetClothesEffectData(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
		return null;
	}

	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x2C79F88", Offset = "0x2C79F88", VA = "0x2C79F88")]
	private ClothEffectObject GetClothesEffectDataByTicket(uint ticket)
	{
		return null;
	}

	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x2C78508", Offset = "0x2C78508", VA = "0x2C78508")]
	private void CancelClothesEffectLoadings()
	{
	}

	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x2C7A1D0", Offset = "0x2C7A1D0", VA = "0x2C7A1D0")]
	public ClothEffectObject PlayEffect(UIModelAvatarBase.EWardrobeType type, ResourceID res)
	{
		return null;
	}

	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x2C7A70C", Offset = "0x2C7A70C", VA = "0x2C7A70C")]
	private void OnEffectDataLoaded(uint ticket, bool ok, Object obj)
	{
	}

	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x2C7A55C", Offset = "0x2C7A55C", VA = "0x2C7A55C")]
	private void OnEffectDataLoaded(ClothEffectObject effectData, Object obj, bool async)
	{
	}

	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x2C7AA7C", Offset = "0x2C7AA7C", VA = "0x2C7AA7C")]
	public void UpdateEffectVisibility(ClothEffectObject effectData)
	{
	}

	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x2C7ACA0", Offset = "0x2C7ACA0", VA = "0x2C7ACA0")]
	public void SetEffectsVisibility(uint flag, bool v)
	{
	}

	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x2C7AEB0", Offset = "0x2C7AEB0", VA = "0x2C7AEB0")]
	public void SetEffectVisibility(UIModelAvatarBase.EWardrobeType wardrobeType, uint flag, bool v)
	{
	}

	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x2C7AF7C", Offset = "0x2C7AF7C", VA = "0x2C7AF7C")]
	public void RemoveAnimEffect(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
	}

	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x2C7B180", Offset = "0x2C7B180", VA = "0x2C7B180")]
	public bool StartDynamicEffect(int id, ResourceID res, bool isVisible)
	{
		return default(bool);
	}

	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x2C7BAEC", Offset = "0x2C7BAEC", VA = "0x2C7BAEC")]
	public void StopDynamicEffect(int id, ResourceID res)
	{
	}

	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x2C7C104", Offset = "0x2C7C104", VA = "0x2C7C104")]
	public void SetDynamicEffectVisibility(int id, bool visible)
	{
	}

	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x2C7C2A4", Offset = "0x2C7C2A4", VA = "0x2C7C2A4")]
	private void StartEffects(List<GameObject> list, bool start)
	{
	}

	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x2C7C448", Offset = "0x2C7C448", VA = "0x2C7C448")]
	private void StartEffects(GameObject go, bool start)
	{
	}

	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x2C7C720", Offset = "0x2C7C720", VA = "0x2C7C720")]
	private void StartAnims(List<GameObject> list, bool start)
	{
	}

	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x2C7C9BC", Offset = "0x2C7C9BC", VA = "0x2C7C9BC")]
	private void EnableRenderers(List<GameObject> list, bool enable)
	{
	}

	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x2C7CB60", Offset = "0x2C7CB60", VA = "0x2C7CB60")]
	private void EnableRenderers(GameObject go, bool enable)
	{
	}

	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x2C7CE7C", Offset = "0x2C7CE7C", VA = "0x2C7CE7C")]
	private void EnableAnimators(List<GameObject> list, bool enable)
	{
	}

	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x2C7B5F4", Offset = "0x2C7B5F4", VA = "0x2C7B5F4")]
	private DynamicEffectData GetDynamicEffectData(int id, bool remove = false)
	{
		return null;
	}

	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x2C7D2F0", Offset = "0x2C7D2F0", VA = "0x2C7D2F0")]
	private DynamicEffectData GetDynamicEffectDataByTicket(uint ticket)
	{
		return null;
	}

	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x2C786EC", Offset = "0x2C786EC", VA = "0x2C786EC")]
	private void CancelDynamicEffectLoadings()
	{
	}

	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x2C7B79C", Offset = "0x2C7B79C", VA = "0x2C7B79C")]
	private void LoadAndPlayDynamicEffect(DynamicEffectData data)
	{
	}

	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x2C7D6B4", Offset = "0x2C7D6B4", VA = "0x2C7D6B4")]
	private void OnAsyncLoadDynamicEffectFromPool(uint ticket, bool ok, Object obj)
	{
	}

	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x2C7DA78", Offset = "0x2C7DA78", VA = "0x2C7DA78")]
	private void OnAsyncLoadDynamicEffect(uint ticket, bool ok, Object obj)
	{
	}

	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x2C7D74C", Offset = "0x2C7D74C", VA = "0x2C7D74C")]
	private void PlayDynamicEffectOnAsyncLoad(uint ticket, bool ok, Object obj, bool isPrefab)
	{
	}

	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x2C7D4A4", Offset = "0x2C7D4A4", VA = "0x2C7D4A4")]
	private void PlayDynamicEffect(DynamicEffectData data, Object obj, bool isPrefab)
	{
	}

	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x2C7BD10", Offset = "0x2C7BD10", VA = "0x2C7BD10")]
	private void StopDynamicEffect(DynamicEffectData data)
	{
	}

	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x2C7C1A0", Offset = "0x2C7C1A0", VA = "0x2C7C1A0")]
	private void SetDynamicEffectVisibility(DynamicEffectData data, bool isVisible, bool force)
	{
	}
}
