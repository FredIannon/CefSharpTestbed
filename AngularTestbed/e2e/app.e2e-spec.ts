import { AngularTestbedPage } from './app.po';

describe('angular-testbed App', () => {
  let page: AngularTestbedPage;

  beforeEach(() => {
    page = new AngularTestbedPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
