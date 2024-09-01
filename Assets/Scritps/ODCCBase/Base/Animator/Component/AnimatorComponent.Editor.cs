#if UNITY_EDITOR
using System.Collections.Generic;
using System.Linq;

using BC.ODCC;

using Sirenix.OdinInspector;

using static BC.OdccBase.AnimatorInfo;

namespace BC.OdccBase
{
	public partial class AnimatorComponent : ComponentBehaviour//.Editor
	{
		public partial class State
		{
			private List<ValueDropdownItem<StateInfo>> StateInfoDropdown()
			{
				List<ValueDropdownItem<StateInfo>> valueDropdownItems = new List<ValueDropdownItem<StateInfo>>();
				if(Component != null && Component.ThisContainer != null)
				{
					if(Component.ThisContainer.TryGetData<AnimatorData>(out var data))
					{
						if(data.animatorInfo != null)
						{
							var list = data.animatorInfo;
							var states = list.SelectMany(item=>item.Infos).SelectMany(item=>item.Infos).ToArray();

							int length = states.Length;
							for(int i = 0 ; i < length ; i++)
							{
								StateInfo state = states[i];
								valueDropdownItems.Add(new ValueDropdownItem<StateInfo>($"{state.layerName}/{state.machineName}/{state.Name}", state));
							}
						}
					}
				}
				return valueDropdownItems;
			}
		}

		public override void BaseValidate()
		{
			base.BaseValidate();

			if(!ThisContainer.TryGetData<AnimatorData>(out var animatorData))
			{
				animatorData = ThisContainer.AddData<AnimatorData>();
			}

			if(animatorData.animatorInfo == null || animatorData.animatorInfo.Count == 0) return;
			allStateList.Clear();
			foreach(StateInfo state in animatorData.animatorInfo[0][0])
			{
				allStateList.Add(new State(this, state));
			}
		}
	}
}

#endif