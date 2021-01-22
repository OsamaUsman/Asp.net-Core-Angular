import { Product } from '../product/product.model';

export class Supplier {
  constructor(
    public id?: number,
    public name?: string,
    public city?: string,
    public state?: string,
    public productId?: number,
    public products?: Product[]) { }
}
