import Property from './property';

export default class Owner {
  id: string;
  name: string;
  gender: string;
  age: number;
  properties: Array<Property>;
}
