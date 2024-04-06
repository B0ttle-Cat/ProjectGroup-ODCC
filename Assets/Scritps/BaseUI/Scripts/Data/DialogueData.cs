using System;
using System.Collections.Generic;

using BC.ODCC;

namespace BC.BaseUI
{
	public class DialogueData : DataObject
	{
		public bool IsAutoNextDialogue = false;
		public float SpeedOfNextDialogue = 0.3f;
		public float SpeedOfShowDialogue = 0.1f;

		public List<string> DialogueList  = new List<string>();
		public int CurrentIndex = 0;

		public Action CallbackEndDialogue = null;
	}
}
