## ODCC(Object-Data-Component Container)란?

유니티로 프로그래밍을 하는 한, 거의 모든 클래스들은 3가지 유형으로 구분이 가능하다는 발상에서 시작 되었으며,
- Object: 게임 오브젝트를 관리하는 용도
- Data: 해당 오브젝트를 표현하는 데이터
- Component: 해당 오브젝트가 수행해야 하는 기능

유니티에서 개발이 길어질 수록 늘어가는 GameObject와 길어지는 Component의 Scritps들을 어떻게 관리해야 하는지에 대한 설계규칙을 제공해 주는 프레임워크 입니다.
또한 해당 설계 규칙이 준수되는 한 사용할 수 있는 여러 도구를 포함합니다.

이 도구들이 정상적인 동작을 위해서는 [Odin Inspector and Serializer]를 필요로 합니다. 해당 에셋은 별도로 받으셔야 합니다.
이를 사용하지 않는다면 일부 수정이 필요합니다.

## 주요 폴더 및 스크립트 

Assets/Scritps/Base
* ODCC와 별개로 개발된 기타 도구들 입니다.

Assets/Scritps/ODCC
* ODCC와 관련된 스크립트를 포함합니다.

Assets/Scritps/ODCC/Scripts
* OdccManager 를 비롯해 ODCC 프레임워크가 의도되로 동작하기 위한 기능을 제공합니다.

Assets/Scritps/ODCC/Scripts/MainScripts
* 실제 사용자가 상속받아 사용해야 할 부모 Class를 제공해 줍니다.
  * ObjectBehaviour.cs
    * 객채를 관리할 게임오브젝트를 지정할때 사용합니다.
  * DataObject.cs
    * 게임오브젝트에 등록해야할 데이터를 만들때 사용합니다.
  * ComponentBehaviour.cs
    * 게임오브젝트에서 동작해야할 기능을 작성할 떄 사용됩니다.


[ProjectGroup-GamePlayer](https://github.com/B0ttle-Cat/ProjectGroup-GamePlayer/tree/master) 는 ODCC를 기반으로 만들어지고 있는 프로젝트 입니다. 
Assets/Scripts 에서 ODCC의 사용 방식을 확인해 보실 수 있습니다.
